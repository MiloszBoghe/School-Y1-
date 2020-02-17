CREATE OR REPLACE FUNCTION bruto_jaarloon(p_employee_id employees.employee_id%TYPE)
 RETURN NUMBER
 AS
	v_maandloon       employees.salary%TYPE;
	v_jaarloon		  NUMBER;
	v_commissie		  employees.commission_pct%TYPE;
 BEGIN
	SELECT salary, NVL(commission_pct, 0) 
	INTO v_maandloon, v_commissie 
	FROM employees 
	WHERE employee_id = p_employee_id;
	
	v_jaarloon := v_maandloon + v_maandloon * v_commissie * 12;
	RETURN v_jaarloon;
 END;
 /
