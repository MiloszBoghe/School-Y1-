CREATE OR REPLACE PROCEDURE toon_laatste_emp
 IS
v_emp_id            EMPLOYEES.EMPLOYEE_ID%TYPE;
v_naam              VARCHAR2(60);
v_hire_date         EMPLOYEES.HIRE_DATE%TYPE;
 BEGIN 
	SELECT EMPLOYEE_ID, FIRST_NAME || ' ' || LAST_NAME, HIRE_DATE	
	INTO v_emp_id, v_naam, v_hire_date
	FROM EMPLOYEES
	WHERE HIRE_DATE = (SELECT MAX(HIRE_DATE) FROM EMPLOYEES); // runt niet want meer dan 1 resultaten

	DBMS_OUTPUT.PUT_LINE('De laatst aangeworven medewerker is ' || v_emp_id || ' met naam ' || v_naam || ' en werd aangeworven op ' || to_char(v_hire_date, 'DD/MM/YY'));
 END toon_laatste_emp;
/
