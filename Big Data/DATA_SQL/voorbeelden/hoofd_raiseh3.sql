declare
	v_aantal_rijen number(4);
begin
	raise_salary_dept('Administration',10,v_aantal_rijen);
	dbms_output.put_line('Er werden '||v_aantal_rijen||' bewerkt.');
END;
/
