CREATE OR REPLACE FUNCTION schrikkeljaar(p_jaar NUMBER)
 RETURN VARCHAR2
 AS
	v_jaar NUMBER(4) := p_jaar;
 BEGIN
 -- true if the year is a multiple
 -- of 4 and not multiple of 100.
 -- OR year is multiple of 400.

 -- Extract(YEAR FROM SYSDATE)
 
 IF MOD(v_jaar, 4) = 0 AND MOD(v_jaar, 100) != 0 OR MOD(v_jaar, 400) = 0 THEN
	return 'het jaar ' || to_char(p_jaar) || ' is een schrikkeljaar';
 ELSE
	return 'het jaar ' || to_char(p_jaar) || ' is geen schrikkeljaar';
 END IF;
 END;
/