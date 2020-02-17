from random import randint
getallenlijst = []
gemiddelde = 0
som = 0
getal = 0
aantal = 0

for i in range(100):
    getallenlijst.append(randint(-4,15))
    som += getallenlijst[i]

gemiddelde = som/100
for getal in getallenlijst:
    if getal >= gemiddelde -2 and getal <= gemiddelde + 2:
        aantal += 1

print(aantal)
print(getallenlijst)
print(gemiddelde)