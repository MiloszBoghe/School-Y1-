create or replace procedure show_emp
is
	v_voornaam	employees.first_name%type;
	v_naam		employees.last_name%type;
	v_emp_id	employees.employee_id%type:=121;
begin
	select first_name, last_name
	into v_voornaam, v_naam
	from employees
	where employee_id = v_emp_id;
	dbms_output.put_line(v_voornaam||' '||v_naam);
end show_emp;
/