create or replace trigger au_empsalary
after update of salary
on employees
for each row
begin
if (:Old.salary *1.05 < :NEW.salary) then
	raise_application_error(-20666, 'Een raise van meer dan 5% mag niet.');
elsif :new.salary < :old.salary then
	raise_application_error(-20666, 'Loonsverlaging mag niet.');
end if; 
end;
/