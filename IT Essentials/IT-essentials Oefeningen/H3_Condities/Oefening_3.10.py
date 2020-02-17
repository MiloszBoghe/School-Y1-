HUIDIG_JAAR = 2018
leeftijd = int(input("Geef je leeftijd: "))
aansluitingsjaar = int(input("Geef het jaar waarin je je aansloot: "))
basisbedrag = 100
reductie = 2.5 * (HUIDIG_JAAR - aansluitingsjaar)
if leeftijd < 21:
    reductie += 14.5
elif leeftijd > 60:
    reductie += 14.5
prijs = basisbedrag - reductie
if prijs < 62.5:
    prijs = 62.5
print ("prijs: ", prijs)

