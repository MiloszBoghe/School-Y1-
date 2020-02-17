CREATE OR REPLACE PROCEDURE asterisk_sal
 (p_employee_id     IN     EMPLOYEES.EMPLOYEE_ID%TYPE)
 AS
 v_salary                  EMPLOYEES.SALARY%TYPE;
 v_asterisks               VARCHAR2(30);
 v_max_asterisks	       VARCHAR2(30);
 BEGIN
   SELECT SALARY 
   INTO v_salary
   FROM EMPLOYEES
   WHERE EMPLOYEE_ID = p_employee_id;
   
   v_max_asterisks := TRUNC(v_salary / 1000);
   
   FOR i_teller IN 1..v_max_asterisks
     LOOP
         v_asterisks := v_asterisks || '*';
     END LOOP;
	 
   DBMS_OUTPUT.PUT_LINE(v_asterisks);
 END;
