create or replace procedure minimumlonen(p_landnaam countries.country_name%type, p_minsalary employees.salary%type)
is
begin
update employees
	set salary = p_minsalary 
	where salary < p_minsalary and department_id in 
		(select department_id 
		from departments
		where location_id in
			(select location_id 
			from locations
			where country_id = 
				(select country_id
				from countries
				where country_name = p_landnaam)));
		dbms_output.put_line('Er werd(en) '||SQL%ROWCOUNT||' rijen aangepast in employees');
end;
/
 db.movieDetails.find({$or:[{countries: {$nin:['USA','UK']} },{countries:'Belgium'},{countries:'France'}] },{title:1,producer:1,countries:1,actors:1}).pretty().skip(50).limit(1)