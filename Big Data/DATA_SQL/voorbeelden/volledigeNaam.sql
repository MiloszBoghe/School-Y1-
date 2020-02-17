create or replace function volledigeNaam
return varchar2
as
	v_naam varchar2(30);
	v_aantal pls_integer;
	v_manager pls_integer;
	v_department pls_integer;
begin
	select
	select manager_id into v_manager from departments;
	select max(count(employee_id)) into v_aantal from employees where manager_id IS NOT null group by department_id;
	select last_name||' '||first_name into v_naam from employees where v_aantal = 
	(select max(count(employee_id)) from employees group by department_id) and v_manager = employee_id;
	return v_naam;
end;
/
