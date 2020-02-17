CREATE OR REPLACE PROCEDURE grootste_dept
 IS
  v_department_id		EMPLOYEES.DEPARTMENT_ID%TYPE;
  v_department_name		DEPARTMENTS.DEPARTMENT_NAME%TYPE;
  v_name            		VARCHAR2(60);
  v_salary         		EMPLOYEES.SALARY%TYPE;
 BEGIN
	
/*Grootste Department opvragen*/
	SELECT DEPARTMENT_ID
	INTO v_department_id
	FROM EMPLOYEES
	GROUP BY DEPARTMENT_ID
	HAVING count(EMPLOYEE_ID) = (SELECT max(count(EMPLOYEE_ID)) FROM employees GROUP BY department_id);
	
/*Department-naam opvragen*/
	SELECT DEPARTMENT_NAME		
	INTO v_department_name
	FROM DEPARTMENTS
	WHERE DEPARTMENT_ID = v_department_id;
	
/*Naam van persoon met grootste salaris in het grootste department opvragen*/
	SELECT FIRST_NAME || ' ' || LAST_NAME, SALARY
	INTO v_name, v_salary
	FROM EMPLOYEES
	WHERE SALARY = (SELECT MAX(SALARY) FROM EMPLOYEES WHERE department_id = v_department_id);
	DBMS_OUTPUT.PUT_LINE('Het grootste departement is ' || v_department_name || ' - Grootste salaris in dit departement behoort tot ' || v_name || ' met een salaris van ' || to_char(v_salary, 999999) || 'euro');
/*2 mensen hebben de grootste salaris dus geeft deze proc een error*/
 END grootste_dept;
/
