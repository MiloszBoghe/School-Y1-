aantal_sterren = int(input("Geef het aantal sterren(1-5): "))
code = input("Geef code (O, H, V of A): ")
aantal_overnachtingen = int(input("Geef het aantal overnachtingen: "))
seizoen = input("Geef seizoen (H, L of T): ")

    if aantal_sterren < 2:
        prijs = 30 * aantal_overnachtingen
    elif aantal_sterren < 4:
        prijs = 40 * aantal_overnachtingen
    else:
        prijs = 55 * aantal_overnachtingen
    if code == "O":
        prijs *= 1.20
    elif code == "H":
        prijs *= 0.50
    elif code == "V":
        prijs *= 0.60
    else:
        prijs = prijs * 0.60 + 80 * aantal_overnachtingen
    if (code == "O" or code == "H") and seizoen == "L":
        prijs *= 0.90

    print("De kostprijs van een vakantie voor 1 persoon is ", prijs)


