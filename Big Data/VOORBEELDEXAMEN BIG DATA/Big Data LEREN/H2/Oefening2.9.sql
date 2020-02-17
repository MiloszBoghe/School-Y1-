CREATE OR REPLACE FUNCTION get_jubileumdatum(p_last_name employees.last_name%TYPE, p_first_name employees.first_name%TYPE)
 RETURN VARCHAR2 
 AS 
 v_datum 	DATE;
 v_output 	VARCHAR2(20);
 BEGIN
    SELECT HIRE_DATE
    INTO v_datum
    FROM EMPLOYEES
    WHERE LAST_NAME = p_last_name AND FIRST_NAME = p_first_name;
        
    v_datum := ADD_MONTHS(v_datum, (12 * 25));
    IF v_datum < SYSDATE THEN
        v_output := 'werd reeds gevierd';
    ELSIF LOWER(TO_CHAR(v_datum, 'DAY')) = 'VRIJDAG' THEN
        v_output := TO_CHAR(v_datum, 'DD/MM/YYYY');
    ELSE
        v_output := TO_CHAR(NEXT_DAY(v_datum, 'VRIJDAG'), 'DD/MM/YYYY');
    END IF;
    RETURN v_output;
 END;
 /