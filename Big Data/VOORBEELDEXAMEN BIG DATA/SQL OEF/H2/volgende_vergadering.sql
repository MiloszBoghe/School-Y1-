CREATE OR REPLACE FUNCTION volgende_vergadering
RETURN DATE
AS
v_huidigeMaand NUMBER(2) := EXTRACT(MONTH from SYSDATE);
v_huidigJaar NUMBER(4) := EXTRACT(YEAR from SYSDATE);
v_eersteDagMaand DATE := TO_DATE('01/0'||v_huidigeMaand||'/'||v_huidigJaar, 'DD/MM/YYYY');
v_vergaderingsdag DATE;
v_dag NUMBER;
BEGIN
v_vergaderingsdag := NEXT_DAY(v_eersteDagMaand, 'MONDAY');
v_dag := EXTRACT(DAY from v_vergaderingsdag);

IF SYSDATE > v_vergaderingsdag THEN
v_vergaderingsdag := NEXT_DAY(LAST_DAY(SYSDATE), 'MONDAY');
END IF;

IF v_dag = 1 THEN
	IF v_huidigeMaand = 1 OR v_huidigeMaand = 5 THEN
		v_vergaderingsdag := v_vergaderingsdag +1;
	END IF;
END IF;
RETURN v_vergaderingsdag;
END;
/