create or replace function dagen_einde_maand
return number
as v_days number(2);
begin 
v_days := last_day(sysdate) - sysdate;

return v_days;
end;
/


