create or replace trigger bus_salary_trigger
before update of min_salary, max_salary
on jobs
begin
	if(lower(user) = lower('student') or lower(user) = lower('bezoeker')) then
		raise_application_error(-20666, 'U HEEFT GEEN RECHTEN, SLAAF');
	else 
		dbms_output.put_line('WEET U ZEKER?');
	end if;		
end;
/