familienaam = input("Geef je familienaam: ")
premie = 0
totale_premie = 0
hoogste_premie = 0
while (familienaam != "/" and familienaam != "\*"):
    voornaam = input("Geef je voornaam: ")
    dienstjaren = int(input("Geef een getal van 0-40: "))
    while dienstjaren < 0 and dienstjaren >= 40:
        dienstjaren = int(input("Fout! Geef een getal van 0-40: "))
    if dienstjaren < 5:
        premie = 0
    else:
        premie = dienstjaren * 25
        totale_premie += premie
        if premie > hoogste_premie:
            hoogste_premie = premie
    print("naam en voornaam: ", familienaam,voornaam, ", Dienstjaren:", dienstjaren, "premie: ", premie)
    familienaam = input("Geef je familienaam: ")
print("totale premie: ", totale_premie, "\n", "hoogste premie: ", hoogste_premie)

