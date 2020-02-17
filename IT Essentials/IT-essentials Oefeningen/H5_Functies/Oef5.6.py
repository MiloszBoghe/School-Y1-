"""
from random import randint
def berekening():
    getal1 = randint(0,20)
    getal2 = randint(0,getal1)
    return getal1, getal2


for i in range(1,6):
    print("Reeks", i)
    for j in range(1,6):
        getal1, getal2 = berekening()
        print(j,")",getal1, "-", getal2, "=")
"""
from random import randint
for i in range(1,6):
    print("Reeks", i)
    for j in range(1,6):
        getal1 = randint(0, 20)
        getal2 = randint(0, getal1)
        print(j,")",getal1, "-", getal2, "=")
