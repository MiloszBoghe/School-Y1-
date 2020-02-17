/* Anoniem Block */
CREATE OR REPLACE PROCEDURE asterisk_sal2_blok
DECLARE
 v_asterisks       VARCHAR2(50);
 BEGIN
   asterisk_sal(120, v_asterisks);
   DBMS_OUTPUT.PUT_LINE(v_asterisks);
 END;

/* IN SQL*PLUS -> Bind-variable
VARIABLE b_asterisks VARCHAR2(50)
EXEC asterisk_sal(120, :b_asterisks)
*/