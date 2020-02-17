lengte_vlucht = int(input("Afstand in km: "))
klasse = int(input("klasse: "))

if lengte_vlucht > 2999:
    prijs = 0.12 * lengte_vlucht
elif lengte_vlucht >= 1000:
    prijs = 0.20 * lengte_vlucht
else:
    prijs = 0.25 * lengte_vlucht

if klasse == 3:
    prijs = prijs * 1.30
elif klasse == 2:
    prijs = prijs * 0.80

print(prijs)
