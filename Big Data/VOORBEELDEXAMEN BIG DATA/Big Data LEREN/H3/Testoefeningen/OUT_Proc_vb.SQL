CREATE OR REPLACE PROCEDURE raise_salary_2_dept
 (p_dept_name IN departments.department_name%type
 ,p_percent IN number
 ,p_count_emp OUT number)
 AS
 BEGIN
 UPDATE employees
 SET salary = salary * (1 + p_percent/100)
 WHERE department_id = (SELECT department_id FROM departments
 WHERE department_name = p_dept_name);
 p_count_emp := SQL%rowcount;
 END raise_salary_2_dept;
/