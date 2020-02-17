create or replace function fullname
return varchar2
as v_dep number(3);
v_firstname varchar2(10);
v_lastname varchar2(10);
v_emp number(3);
begin
	select department_id 
	into v_dep 
	from employees
	group by department_id
	having count(employee_id) = 
	(select max(count(employee_id)) 
	from employees
	group by department_id);
	
	select first_name, last_name
	into v_firstname, v_lastname
	from employees
	where employee_id = (select manager_id from departments where department_id = v_dep);
	
	return v_firstname||' '||v_lastname;
end;
/