from random import randint
lijst = []
teller = 0
som = 0
som2= 0

for i in range(500):
    getal = randint(0,10000)
    lijst.append(getal)

for getal in lijst:
    if getal > 5000:
        teller += 1
        som += getal
        if getal > 8000:
            som2 += getal

if teller > 250:
    print("som van getallen groter dan 5000:",som)
else:
    print("som van getallen groter dan 8000:",som2)
print(teller)
