CREATE OR REPLACE PROCEDURE landenlijst
 IS
  v_aantal       INTEGER(4)      := 0;
 BEGIN
  FOR country IN (SELECT COUNTRY_NAME FROM COUNTRIES)
   LOOP
     DBMS_OUTPUT.PUT_LINE(country.COUNTRY_NAME);
     v_aantal := v_aantal + 1;
   END LOOP;

 DBMS_OUTPUT.PUT_LINE('We hebben connecties in '||v_aantal||' landen.');
 END;
/


/*^^^Expliciete cursor zonder naam: country in deze oefening (= plaats in het geheugen)*/