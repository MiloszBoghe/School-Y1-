CREATE OR REPLACE PROCEDURE show_employees
 IS
	v_voornaam	employees.first_name%type;
	v_achternaam	employees.last_name%type;
	v_emp_id		employees.employee_id%type := 100;
 BEGIN
 	SELECT first_name, last_name
 	INTO v_voornaam, v_achternaam
	FROM employees
	WHERE employee_id = v_emp_id
	DBMS_OUTPUT.PUT_LINE(v_voornaam|| ' ' ||v_achternaam);
 END show_employees;
/
