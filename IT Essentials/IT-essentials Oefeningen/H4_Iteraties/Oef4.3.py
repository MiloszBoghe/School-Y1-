getal = int(input("Geef een getal in: "))
som = 0
aantal_neg = 0
while getal != 0:
    som += getal
    print("som:", som)
    if getal < 0:
        aantal_neg += 1

    getal = int(input("Geef een getal in: "))
print("negatieve getallen:", aantal_neg)