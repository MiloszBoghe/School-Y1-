CREATE OR REPLACE FUNCTION dagen_einde_maand
 RETURN NUMBER
 AS
	v_dagen_tot_einde_maand 	NUMBER(2);
 BEGIN
	v_dagen_tot_einde_maand := last_day(sysdate) - sysdate;
	RETURN v_dagen_tot_einde_maand;
 END;

/* OF
CREATE OR REPLACE FUNCTION dagen_einde_maand
RETURN NUMBER
AS
BEGIN
RETURN last_day(sysdate) - sysdate;
END;
*/