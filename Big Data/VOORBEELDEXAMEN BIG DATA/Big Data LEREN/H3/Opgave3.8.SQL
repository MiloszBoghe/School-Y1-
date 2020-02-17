CREATE OR REPLACE PROCEDURE country_dept(P_COUNTRY_ID IN COUNTRIES.COUNTRY_ID%TYPE)
 IS
  v_teller		NUMBER(3) := 0;
 BEGIN
  FOR department IN (SELECT d.DEPARTMENT_NAME, c.COUNTRY_NAME, c.COUNTRY_ID, l.LOCATION_ID FROM DEPARTMENTS
					 d JOIN LOCATIONS l on(d.location_id = l.location_id) join COUNTRIES c on(l.country_id = c.country_id) 
					 where c.country_id = P_COUNTRY_ID)
   LOOP
     DBMS_OUTPUT.PUT_LINE(department.DEPARTMENT_NAME);
	 v_teller := v_teller + 1;
   END LOOP;
	IF(v_teller = 0) THEN
	 DBMS_OUTPUT.PUT_LINE('Er zijn geen departementen gevestigd in het land met id '|| P_COUNTRY_ID);
	END IF;
 END;
/