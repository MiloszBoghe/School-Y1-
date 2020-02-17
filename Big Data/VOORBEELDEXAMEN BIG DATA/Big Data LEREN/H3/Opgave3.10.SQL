CREATE OR REPLACE PROCEDURE toon_steden
 (p_land_id        COUNTRIES.COUNTRY_ID%TYPE)
 AS
   v_land_naam     COUNTRIES.COUNTRY_NAME%TYPE;
   v_aantal_empl   NUMBER;
 BEGIN
   SELECT COUNTRY_NAME
   INTO v_land_naam
   FROM COUNTRIES
   WHERE COUNTRY_ID = p_land_id;

   FOR locations IN (SELECT LOCATION_ID, CITY FROM LOCATIONS WHERE COUNTRY_ID = p_land_id) 
   LOOP

     DBMS_OUTPUT.PUT_LINE('==> ' || v_land_naam || ' - ' || locations.LOCATION_ID || ' ' || locations.CITY);

     FOR departments IN (SELECT DEPARTMENT_ID, DEPARTMENT_NAME FROM DEPARTMENTS WHERE LOCATION_ID = locations.LOCATION_ID) 
	 LOOP

       v_aantal_empl := 0;

       FOR employees IN (SELECT EMPLOYEE_ID FROM EMPLOYEES WHERE DEPARTMENT_ID = departments.DEPARTMENT_ID) 
	   LOOP

         v_aantal_empl := v_aantal_empl + 1;

       END LOOP;

       IF v_aantal_empl != 0 THEN
         DBMS_OUTPUT.PUT_LINE(departments.DEPARTMENT_NAME || ': ' || TO_CHAR(v_aantal_empl) || ' werknemers');
       END IF;
     END LOOP;
   END LOOP;
 END;
/
