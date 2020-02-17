CREATE OR REPLACE FUNCTION schrikkeljaar
 RETURN VARCHAR2
 AS
	v_jaar NUMBER(4);
 BEGIN
	-- true if the year is a multiple 
	-- of 4 and not multiple of 100. 
	-- OR year is multiple of 400. 
  
	-- Extract(YEAR FROM SYSDATE)
	
	v_jaar := extract(YEAR FROM SYSDATE);
	IF (MOD(v_jaar, 4) = 0 AND MOD(v_jaar, 100) != 0) OR MOD(v_jaar, 400) = 0 THEN
		RETURN 'het jaar ' || to_char(v_jaar) || ' is een schrikkeljaar';
	ELSE
		RETURN 'het jaar ' || to_char(v_jaar) || ' is geen schrikkeljaar';
	END IF;
 END;
 /
 
/*
CREATE OR REPLACE FUNCTION schrikkeljaar
 RETURN VARCHAR2
 AS
	v_datum date;
 BEGIN
	v_datum := to_date('01-02' ||to_char(sysdate, 'yyyy'), 'dd-mm-yyyy');
	v_datum := last_day(v_datum);
 IF to_char(v_datum, 'dd') = '29' THEN
	RETURN 'het jaar ' || to_char(sysdate, 'yyyy') || ' is een schrikkeljaar';
 ELSE
	RETURN 'het jaar ' || to_char(sysdate, 'yyyy') || ' is geen schrikkeljaar';
 END IF;
 END;
*/
