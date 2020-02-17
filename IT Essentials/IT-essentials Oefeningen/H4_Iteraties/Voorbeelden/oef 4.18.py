#invoercontrole ingegeven getal moet >= 0 en <= 10 zijn
getal = int(input("geef een getal >=0 en <=10: "))
while getal < 0 or getal > 10:
    getal = int(input("verkeerd getal! >=0 en >=10: "))
