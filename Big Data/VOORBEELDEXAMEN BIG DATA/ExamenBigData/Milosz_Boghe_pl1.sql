create or replace procedure plan_1tin_zit2(p_year number)
as v_eersteDatum date := to_date('15/08/2019','DD/MM/YYYY');
v_year varchar2(4) := to_char(sysdate,'YYYY');
v_nextyear varchar2(4) := to_char(ADD_MONTHS(sysdate,12),'YYYY');
begin
	for i in (select olodcode, olodnaam from olods) loop 
		if lower(SUBSTR(i.olodcode,2,4)) = '1tin' then
				v_eersteDatum := v_eersteDatum + 2;
			if to_char(v_eersteDatum,'DAY') ='SATURDAY' then
				v_eersteDatum := v_eersteDatum + 2;
			elsif to_char(v_eersteDatum,'DAY') = 'SUNDAY' then
				v_eersteDatum := v_eersteDatum + 1;
			end if;
			insert into examendatum_olod values (v_year||' - '||v_nextyear, 'aug-sep', i.olodcode, v_eersteDatum);
		end if;
	end loop;
end;
/