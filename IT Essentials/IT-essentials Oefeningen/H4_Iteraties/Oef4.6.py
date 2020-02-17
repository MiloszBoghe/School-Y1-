artikelnummer = int(input("Geef het artikelnummer: "))
totaal_bedrag = 0

while artikelnummer != 999:
    hoeveelheid = int(input("Geef de hoeveelheid: "))
    eenheidsprijs = int(input("Geef de eenheidsprijs: "))
    artikel_bedrag = eenheidsprijs * hoeveelheid
    print("Artikelnummer: ", artikelnummer,"Hoeveelheid: ", hoeveelheid,
          "Eenheidsprijs: ", eenheidsprijs, "Totaal voor dit artikel: ", artikel_bedrag )
    totaal_bedrag += artikel_bedrag
    artikelnummer = int(input("Geef het artikelnummer: "))
print("Totaal: ", totaal_bedrag)