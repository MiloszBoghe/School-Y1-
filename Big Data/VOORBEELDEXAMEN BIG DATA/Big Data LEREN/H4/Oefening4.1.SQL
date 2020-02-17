CREATE OR REPLACE TRIGGER bus_jobs
  BEFORE UPDATE OF min_salary, max_salary
  ON jobs
 DECLARE
 BEGIN
  IF USER IN ('STUDENT', 'BEZOEKER') THEN
		RAISE_APPLICATION_ERROR(-20000, 'Je hebt onvoldoende rechten om deze actie uit te voeren!');
  ELSE
		DBMS_OUTPUT.PUT_LINE('Ben je zeker dat je het min of max salaris wil aanpassen? Indien niet voer dan een ROLLBACK uit!');
  END IF;
 END;
/