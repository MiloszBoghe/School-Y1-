naam = input("Geef de naam: ")
brief = 0
totale_brieven = 0
def boete(boeken, dagen, brief):
    res = int((boeken * dagen * 0.07 + brief * 0.84) * 100 + 0.5) / 100
    return res

while naam != "xx":
    boeken = int(input("Geef het aantal boeken: "))
    dagen = int(input("Geef het aantal dagen: "))
    brief = 0
    if dagen >= 45:
        brief += 1
        totale_brieven += 1
    print("Naam:", naam, "Boete:", boete(boeken, dagen, brief),"euro")
    naam= input("Geef de naam: ")

print("Totaal aantal brieven:", totale_brieven)
