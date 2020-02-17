CREATE OR REPLACREATE OR REPLACE PROCEDURE minimumlonen
 (p_land         IN countries.country_name%TYPE , p_minloon     IN employees.salary%TYPE ,p_aantal_rijen    OUT number) 
 IS
 BEGIN
  UPDATE employees     
  SET salary = p_minloon     
  
  WHERE department_id IN (SELECT department_id FROM departments 
  WHERE location_id IN (SELECT location_id FROM locations 
  WHERE country_id = (SELECT country_id FROM countries WHERE UPPER(country_name) = UPPER(p_land)))) AND salary < p_minloon;
  
  p_aantal_rijen := sql%rowcount; 
 END;
/