"""
gewicht_appel = int(input("geef het gewicht van een appel in gram: "))
som_gewicht = gewicht_appel

for i in range (1,101):
    print(aantal, "appel(s): ",som_gewicht)
    som_gewicht += gewicht_appel
"""
gewicht_appel = int(input("geef het gewicht van een appel in gram: "))
som_gewicht = gewicht_appel
aantal = 0
while aantal < 100:
    aantal += 1
    print(aantal, "appel(s): ", som_gewicht)
    som_gewicht += gewicht_appel
