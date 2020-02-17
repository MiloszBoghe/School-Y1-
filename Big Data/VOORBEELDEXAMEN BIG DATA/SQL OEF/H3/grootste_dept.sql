create or replace procedure grootste_dept
as v_departmentnaam varchar2(20);
v_departmentid number(3);
v_empid number(3);
v_empnaam varchar2(40);
v_empsalary employees.salary%type;
begin

select department_id
into v_departmentid
from employees
group by department_id
having count(employee_id) = 
(select max(count(employee_id)) from employees group by department_id);

select department_name 
into v_departmentnaam 
from departments
where department_id=v_departmentid;

select last_name||' '||first_name, salary 
into v_empnaam, v_empsalary 
from employees 
where department_id = v_departmentid and salary = (select max(salary) from employees where department_id = v_departmentid);

dbms_output.put_line(v_departmentid||' '||v_departmentnaam||'- Employee name: '||v_empnaam||'- employee salary: '||v_empsalary);

end;
/