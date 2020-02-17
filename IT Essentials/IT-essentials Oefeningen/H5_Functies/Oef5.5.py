lidnummer = int(input("Geef een lidnummer van 7 cijfers: "))
def controleer(lidnummer):
    cijfer2 = int(lidnummer / 100000) % 10
    cijfer4 = int(lidnummer / 1000) % 10
    laatstecijfers = lidnummer % 100


    if(cijfer2 *10 + cijfer4 == laatstecijfers):
        res = "Inkom = Gratis"
    else:
        res = "Inkom = Niet gratis"
    return res

print(controleer(lidnummer))
