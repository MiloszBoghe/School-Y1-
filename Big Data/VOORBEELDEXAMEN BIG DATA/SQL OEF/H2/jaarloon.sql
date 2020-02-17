create or replace function jaarloon(p_emp_id employees.employee_id%type)
return number
as v_salary employees.salary%type;
v_comm employees.commission_pct%type;
begin
select salary, NVL(commission_pct, 0) 
into v_salary, v_comm
from employees
where employee_id = p_emp_id;

return v_salary*12*(1+v_comm);
end;
/