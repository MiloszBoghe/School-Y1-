CREATE OR REPLACE PROCEDURE del_ctry
(p_country_id IN countries.country_id%type)
IS
BEGIN
    DELETE FROM countries
    WHERE country_id = p_country_id;
    IF SQL%NOTFOUND THEN
        DBMS_OUTPUT.PUT_LINE('Er werden geen rijen verwijderd.');
    ELSIF    SQL%ROWCOUNT = 1 THEN
        DBMS_OUTPUT.PUT_LINE('Er werd 1 rij verwijderd');
    ELSE
        DBMS_OUTPUT.PUT_LINE('Er werden '|| SQL%ROWCOUNT||' rijen verwijderd.');
    ENDIF;
END del_ctry;
/