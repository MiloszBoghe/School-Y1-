aantal_gesprekken = int(input("Geef het aantal gesprekken: "))
aantal_minuten_buitenland = int(input("Geef het aantal minuten dat er naar het buitenland: "))
VAST_BEDRAG = 20

bedrag_maand = (VAST_BEDRAG/2 + aantal_minuten_buitenland * 0.50 + aantal_gesprekken * 0.12) * 1.21
print(round(bedrag_maand, 2))