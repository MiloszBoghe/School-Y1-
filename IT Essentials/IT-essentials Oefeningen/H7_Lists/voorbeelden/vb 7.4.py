getallenlijst = []
getal = 0
som = 0
aantal = 0
for i in range(10):
    getal = int(input("Geef een getal: "))
    getallenlijst.append(getal)
    som += getal

gemiddelde = som / 10
for getal in getallenlijst:
    if getal < gemiddelde:
        aantal += 1
print("Aantal getallen kleiner dan gemiddelde: ", aantal)