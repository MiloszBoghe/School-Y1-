create or replace function schrikkeljaar(p_year number)
return varchar2
as v_result varchar2(40);
begin
	if mod(p_year,4) = 0 and mod(p_year,100) !=0 or mod(p_year, 400) = 0  then
		v_result := 'het jaar '||p_year||' is een schrikkeljaar';
	else	
		v_result := 'het jaar '||p_year||' is geen schrikkeljaar';
	end if;
return v_result;
end;
/