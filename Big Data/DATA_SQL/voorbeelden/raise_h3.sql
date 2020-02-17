CREATE OR REPLACE PROCEDURE raise_salary_dept (p_dept_name IN departments.department_name%type,
                                               p_percent   IN  NUMBER,
                                               p_count_emp OUT NUMBER)
AS
        v_dept_id departments.department_id%type;
BEGIN
        UPDATE
                employees
        SET
                salary = salary*(1+p_percent/100)
        WHERE
                department_id = v_dept_id;
        p_count_emp := SQL%rowcount;
END raise_salary_dept;
/