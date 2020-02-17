getallenlijst = []
som = 0
teller = 0
for i in range(15):
    getal = int(input("Geef een geheel getal: "))
    getallenlijst.append(getal)
    som += getal

gemiddelde = som / 15

for getal in getallenlijst:
    if getal < gemiddelde:
        teller += 1

print("{:.2f}% van de getallen zijn kleiner dan het gemiddelde en het gemiddelde is {:.1f}".format((teller/15*100),gemiddelde))
