create or replace procedure toon_laatste_emp
as v_empid employees.employee_id%type;
v_fullname varchar2(40);
v_hiredate date;
begin
	select hire_date, employee_id, first_name||' '||last_name 
	into v_hiredate, v_empid, v_fullname
	from employees 
	where hire_date = 
	(select max(hire_date) 
	from employees);
	DBMS_OUTPUT.PUT_LINE('De laatst aangeworven medewerker is '||v_fullname||' HireDate: '||v_hiredate||' ID: '||v_empid);
end;
/