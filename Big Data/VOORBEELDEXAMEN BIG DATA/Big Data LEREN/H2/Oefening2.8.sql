CREATE OR REPLACE FUNCTION hoofd_meeste_werknemers
 RETURN VARCHAR2
 AS
	v_department_id       	employees.department_id%type;
	v_aantal_werknemers		NUMBER;
	v_manager_id  	 		employees.manager_id%type;
	v_firstname     		employees.first_name%type;
	v_lastname    			employees.last_name%type;
 BEGIN
	SELECT department_id, count(employee_id)
	INTO v_department_id, v_aantal_werknemers 
	FROM employees
	GROUP BY department_id 
	HAVING count(employee_id) = (SELECT max(count(employee_id)) FROM employees GROUP BY department_id);
	
	SELECT manager_id 
	INTO v_manager_id 
	FROM departments 
	WHERE department_id = v_department_id;
	
	SELECT first_name, last_name 
	INTO v_firstname, v_lastname 
	FROM employees 
	WHERE employee_id = v_manager_id;
	
	RETURN v_firstname || ' ' || v_lastname;
 END;
/