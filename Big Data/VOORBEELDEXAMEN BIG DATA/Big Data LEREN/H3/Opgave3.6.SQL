CREATE OR REPLACE PROCEDURE asterisk_sal2
(p_employee_id     IN     EMPLOYEES.EMPLOYEE_ID%TYPE, p_asterisks       OUT    VARCHAR2)
 AS
  v_salary                  EMPLOYEES.SALARY%TYPE;
  v_asterisks               VARCHAR2(50);
 BEGIN
  SELECT SALARY
  INTO v_salary
  FROM EMPLOYEES
  WHERE EMPLOYEE_ID = p_employee_id;

  FOR i_teller IN 1..TRUNC(v_salary / 1000)
    LOOP
        v_asterisks := v_asterisks || '*';
    END LOOP;
  p_asterisks := v_asterisks;
 END;
