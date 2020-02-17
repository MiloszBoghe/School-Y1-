def lidgeld(naam, leeftijd, aantal_kinderen, inkomen, jaren_lid):
    prijs = 100
    if leeftijd >= 60:
        prijs -= 15
    if aantal_kinderen > 4:
        prijs -= 35
    else:
        prijs -= aantal_kinderen * 7.5
    if jaren_lid >= 20:
        prijs -= 12.5
    if inkomen < 7500:
        prijs -= 25
    if prijs < 50:
        prijs = 50
    return prijs


HUIDIG_JAAR = 2018
naam = input("Geef de naam van het lid: ")
while (naam != "x" and naam != "X"):
    leeftijd = int(input("Geef de leeftijd: "))
    aantal_kinderen = int(input("Geef het aantal kinderen ten laste: "))
    inkomen = float(input("Geef je inkomen: "))
    aansluittingsjaar = int(input("Geef het aansluittingsjaar: "))
    jaren_lid = HUIDIG_JAAR - aansluittingsjaar
    print(lidgeld(naam,leeftijd,aantal_kinderen,inkomen,jaren_lid))
    naam = input("Geef de naam van het lid: ")



