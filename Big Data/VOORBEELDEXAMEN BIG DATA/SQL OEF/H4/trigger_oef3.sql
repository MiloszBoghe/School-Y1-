CREATE OR REPLACE TRIGGER biuds_employees
  BEFORE UPDATE OF SALARY OR INSERT OR DELETE
  ON EMPLOYEES
 DECLARE
 BEGIN
  IF UPDATING THEN
    IF TO_CHAR (SYSDATE, 'HH24:MI') NOT BETWEEN '09:00' AND '17:00' OR TO_CHAR (SYSDATE, 'DAY') = 'MONDAY' THEN
     RAISE_APPLICATION_ERROR (-20000, 'Je mag de maandlonen enkel aanpassen op maandag tussen 09:00 en 17:00!');
    END IF;
  ELSE 
	IF TO_CHAR (SYSDATE, 'DAY') IN ('SATURDAY', 'SUNDAY') THEN
      RAISE_APPLICATION_ERROR (-20001, 'Je mag geen employees in het weekend toevoegen of verwijderen!');
    END IF;
  END IF;
 END;
/