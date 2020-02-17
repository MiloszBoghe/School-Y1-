CREATE OR REPLACE FUNCTION netto(p_sal employees.SALARY%TYPE)
 RETURN VARCHAR2
 AS
	v_netto 	employees.SALARY%TYPE;
 BEGIN
	IF p_sal <= 10000 THEN
		v_netto := p_sal * 0.6;
	ELSIF p_sal <= 16000 THEN
		v_netto := 10000 * 0.6 + (p_sal - 10000) * 0.5;
	ELSE
		v_netto := 10000 * 0.6 + 6000 * 0.5 + (p_sal - 16000) * 0.4;
	END IF;
	RETURN TO_CHAR(v_netto, '99,999.99') || ' euro';
 END;
