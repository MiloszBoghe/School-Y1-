CREATE OR REPLACE FUNCTION netto(p_sal employees.salary%TYPE)
 RETURN VARCHAR2
 AS
	v_netto 	employees.salary%TYPE;
 BEGIN
 	v_netto := p_sal - p_sal * 0.4;
 	RETURN to_char(v_netto, '9,999.00') || ' euro';
 END;
