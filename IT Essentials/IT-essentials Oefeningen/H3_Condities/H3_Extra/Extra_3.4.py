naam = (input("Geef de spelersnaam: "))
prijs_vorig = float(input("Geef de prijs van het vorige seizoen: "))
leeftijd = int(input("leeftijd: "))
gem_beoordelingscijfer = int(input("geef een getal van 0-10: "))
type = input("Geef het type: ")
aantal_doelpunten = int(input("Geef het aantal doelpunten: "))
nieuwe_prijs = 0

if leeftijd < 25:
    nieuwe_prijs = prijs_vorig * 1.10
elif leeftijd < 30:
    nieuwe_prijs = prijs_vorig
else:
    nieuwe_prijs = prijs_vorig * 0.95

if type == "aanvaller":
    if aantal_doelpunten < 5:
        nieuwe_prijs += 10000*aantal_doelpunten
    else:
        nieuwe_prijs += 50000 + (aantal_doelpunten-5)*20000
else:
    nieuwe_prijs += 10000 * gem_beoordelingscijfer
    if type == "doelman" and aantal_doelpunten >= 20:
        nieuwe_prijs -= 9000
print("naam: ",naam, "\nprijs vorig seizoen: ", prijs_vorig, "\nnieuwe prijs: ", nieuwe_prijs)