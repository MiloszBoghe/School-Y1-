create or replace trigger aiuds_job_history
after insert or update or delete
on job_history
declare v_statement varchar2(7);
begin
	if inserting then 
		v_statement := 'insert';
	elsif deleting then 
		v_statement := 'delete';
	else 
		v_statement := 'update';
	end if;
	insert into log_history
	values(user, sysdate,SYSTIMESTAMP, v_statement);
end;
/
