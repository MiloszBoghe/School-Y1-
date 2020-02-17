CREATE OR REPLACE FUNCTION next_employee_id
 RETURN NUMBER
 AS
	v_next_id       employees.employee_id%TYPE;
 BEGIN
	SELECT MAX(EMPLOYEE_ID) INTO v_next_id FROM employees;
	RETURN v_next_id + 1;
 END;
