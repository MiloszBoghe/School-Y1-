CREATE OR REPLACE PROCEDURE print_dept_cursorloop
AS
BEGIN
        FOR rec IN (SELECT department_id  , department_name, manager_id
			FROM departments
			WHERE department_id BETWEEN 10 AND 100)
			LOOP	
                dbms_output.put_line(rec.department_id
                ||' '
                ||rec.department_name
                ||' '
				||rec.manager_id);
        END LOOP;
END;
/