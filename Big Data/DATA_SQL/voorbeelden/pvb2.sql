create or replace procedure add_ctry
is
	v_country_id	countries.country_id%type := 'FR';
	v_country_name	countries.country_name%type default 'France';
	v_region_id	countries.region_id%type := 1;
begin
	insert into countries
	values(v_country_id, v_country_name, v_region_id);
	DBMS_output.put_line('er werden '||SQL%ROWCOUNT||' rijen 
	toegevoegd in de tabel COUNTRIES');
END add_ctry;
/