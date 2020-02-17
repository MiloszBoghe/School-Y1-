from random import randint
def raadgetal(beurten,getal,gok):
    if gok < getal:
        return ("Hoger")
    elif gok > getal:
        return ("Lager")
    else:
        return ("Proficiat, getal geraden")
beurten = 0
getal = randint(0, 10)
gok = 0
while beurten < 4 and getal != gok:
    gok = int(input("Maak een gok: "))
    raadgetal(beurten,getal,gok)
    beurten += 1
    if beurten == 4 and getal != gok:
        print("Verloren")
