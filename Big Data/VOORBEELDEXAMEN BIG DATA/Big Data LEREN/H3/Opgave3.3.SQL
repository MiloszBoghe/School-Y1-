CREATE OR REPLACE PROCEDURE minimumlonen
(p_land_naam	COUNTRIES.COUNTRY_NAME%TYPE, 	p_minimumloon	EMPLOYEES.SALARY%TYPE)
 IS
 BEGIN
   UPDATE EMPLOYEES
   SET SALARY = p_minimumloon
   WHERE department_id IN (SELECT department_id 
						   FROM departments 
						   WHERE location_id 
						   IN (SELECT location_id 
							   FROM locations 
							   WHERE country_id = (SELECT country_id 
												   FROM countries 
												   WHERE UPPER(country_name) = UPPER(p_land))))
 END minimumlonen;
/
