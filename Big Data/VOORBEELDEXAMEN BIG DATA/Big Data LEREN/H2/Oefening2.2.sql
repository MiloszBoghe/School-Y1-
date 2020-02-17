CREATE OR REPLACE FUNCTION aantal_dienstjaren
 (p_hire_date employees.hire_date%TYPE)
 RETURN NUMBER
 AS
	v_dienstjaren 	NUMBER(2);
 BEGIN
	v_dienstjaren := trunc(months_between(sysdate, p_date) / 12);
	RETURN v_dienstjaren;
 END;
/
