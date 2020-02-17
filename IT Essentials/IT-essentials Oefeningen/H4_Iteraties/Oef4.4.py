maan = float(input("Geef het percentage voor de maan in: ")) / 100
jupiter = float(input("Geef het percentage voor jupiter in: ")) / 100
mars = float(input("Geef het percentage voor mars in: ")) / 100
for gewicht in range(50, 125, 5):
    print("Aarde: ", gewicht)
    print("Maan: ", gewicht * maan)
    print("Jupiter: ", gewicht * jupiter)
    print("Mars: ", gewicht * mars)
    print("")
