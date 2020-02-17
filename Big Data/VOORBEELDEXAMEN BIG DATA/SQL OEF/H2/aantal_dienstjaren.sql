create or replace function aantal_dienstjaren(p_date employees.hire_date%type)
return number
as
begin
return trunc(months_between(sysdate,p_date)/12);
end;
/

