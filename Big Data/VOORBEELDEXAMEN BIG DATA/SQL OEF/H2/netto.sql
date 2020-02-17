create or replace function netto(p_bruto employees.salary%type)
return varchar2
as v_belasting number(2,1) := 0.6;
begin
	if (p_bruto <=10000) then 
		return to_char(p_bruto*v_belasting,'999,999.99')||' euro';
	elsif p_bruto <= 16000 then
		return to_char(6000+(p_bruto-10000)*0.5,'999,999.99')||' euro';
	else 
		return to_char(6000+3000+p_bruto*0.4,'999,999.99')||' euro';

end if;
end;
/