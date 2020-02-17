getal = int(input("geef een getal: "))
while getal % 5 != 0:
    if getal % 2 == 0:
        print("Getal is deelbaar door 2")
    getal = int(input("geef een getal: "))
print(getal)

