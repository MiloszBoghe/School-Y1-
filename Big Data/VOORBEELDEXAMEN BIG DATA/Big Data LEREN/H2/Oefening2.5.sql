CREATE OR REPLACE FUNCTION volgende_vergadering
 RETURN VARCHAR2
 AS
	v_vergaderingsdag 	DATE;
 BEGIN
	v_vergaderingsdag := NEXT_DAY(LAST_DAY(SYSDATE), 'MONDAY');
	IF to_char(v_vergaderingsdag,'DD-MM') = '01/01' OR to_char(v_vergaderingsdag,'DD-MM') = '01/05' THEN
		v_vergaderingsdag := v_vergaderingsdag + 1;
	END IF;
	RETURN TO_CHAR(v_vergaderingsdag, 'DD/MM/YYYY');
 END;
/*
	v_datum = last_day(sysdate) + 1;
	IF to_char(v_datum, 'fmday') != 'monday' THEN
		v_datum := next_day(v_datum, 'mon');
	END IF;
	IF to_char(v_datum, 'dd-mm') = '01-01' OR to_char(v_datum, 'dd-mm') = '01-05' THEN
		v_datum = v_datum + 1;
	END IF;
	RETURN v_datum;
 END;
 */