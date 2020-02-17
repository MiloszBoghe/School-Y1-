create or replace trigger test
before insert 
on klas_perstudent_perolod
for each row
declare v_academyYear number(4) := to_number(substr(:new.acjaar,8,4));
begin
	if extract(year from sysdate) > v_academyYear then
		
	end if;
end;
/