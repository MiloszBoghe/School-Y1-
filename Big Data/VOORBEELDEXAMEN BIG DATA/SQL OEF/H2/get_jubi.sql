create or replace function getjubi(p_last_name employees.last_name%type, p_first_name employees.first_name%type)
return varchar2
as v_hiredate date;
v_currentdate date;
begin
	select hire_date
	into v_hiredate
	from employees
	where first_name = p_first_name and last_name = p_last_name;
	
	v_currentdate := add_months(v_hiredate,12*25);
	if(v_currentdate < sysdate) then
		return 'werd reeds gevierd';
	elsif(to_char(v_currentdate,'DAY') = 'FRIDAY') THEN
		return v_currentdate;
	else 
		return next_day(v_currentdate,'FRIDAY');
	end if;
end;
/