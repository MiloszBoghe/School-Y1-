CREATE OR REPLACE PROCEDURE toon_empl_en_verhoog_sal
 (p_department_id        EMPLOYEES.DEPARTMENT_ID%TYPE
 ,p_percentage_verhoging NUMBER)
 AS
 v_naam_dep              DEPARTMENTS.DEPARTMENT_NAME%TYPE;
 v_verhoging             NUMBER;
 v_verhogingen           NUMBER := 0;
 BEGIN
/*percentage omzetten naar decimaal voor makkelijkere berekening*/
   v_verhoging := p_percentage_verhoging / 100;
   
/*Gekozen departement + alle zijn werknemers hun naam, id en salaris tonen en daarna salarissen verhogen met percentage dat ingegeven is*/
   SELECT DEPARTMENT_NAME
   INTO v_naam_dep
   FROM DEPARTMENTS
   WHERE DEPARTMENT_ID = p_department_id;
   
   DBMS_OUTPUT.PUT_LINE('Het gekozen departement is: ' || TO_CHAR(v_naam_dep));
   
   FOR employee IN (SELECT LAST_NAME, EMPLOYEE_ID, SALARY
                    FROM EMPLOYEES
                    WHERE DEPARTMENT_ID = p_department_id) 
	LOOP
     DBMS_OUTPUT.PUT_LINE(employee.LAST_NAME || '     ' || employee.EMPLOYEE_ID || '     ' || employee.SALARY);
     UPDATE EMPLOYEES SET SALARY = employee.SALARY + (employee.SALARY * v_verhoging);
     v_verhogingen := v_verhogingen + 1;
	END LOOP;

/*1 lijn leeghouden en dan het aantal salarisverhogingen tonen*/
   DBMS_OUTPUT.PUT_LINE('');
   DBMS_OUTPUT.PUT_LINE('Aantal salarisverhogingen: ' || v_verhogingen);

/*Wijzingingen tonen door de loop te herhalen*/
	DBMS_OUTPUT.PUT_LINE('SITUATIE NA WIJZIGING');
    FOR employee IN (SELECT LAST_NAME, EMPLOYEE_ID, SALARY
                    FROM EMPLOYEES
                    WHERE DEPARTMENT_ID = p_department_id) 
	LOOP
     DBMS_OUTPUT.PUT_LINE(employee.LAST_NAME || '     ' || employee.EMPLOYEE_ID || '     ' || employee.SALARY);
	END LOOP;
 END;
/