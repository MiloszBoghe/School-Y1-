DECLARE
 v_aantal_rijen	NUMBER(4);
BEGIN
	raise_salary_2('Administration', 10, v_aantal_rijen);
	DBMS_OUTPUT.PUT_LINE('Er werden ' || v_aantal_rijen || ' bewerkt.');
END;
/