VAST_BEDRAG = 25
waterverbruik = int(input("Geef het verbruikte water in kubieke meter: "))
totaal = 0
if waterverbruik <= 30:
    print ("De prijs is ", VAST_BEDRAG, "euro")
elif waterverbruik <= 200:
    totaal = VAST_BEDRAG + 1 * (waterverbruik - 30)
elif waterverbruik <= 5000:
    totaal = VAST_BEDRAG + 170 + 1.15 * (waterverbruik - 200)
else:
    totaal = VAST_BEDRAG + 170 + 1.15 * 4800 + 1.175 * (waterverbruik - 5000)
print ("De prijs is", totaal, "euro")