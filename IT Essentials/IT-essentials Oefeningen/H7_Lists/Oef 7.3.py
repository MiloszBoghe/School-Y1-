lijst = []
positieve_lijst = []
negatieve_lijst = []

for i in range(10):
    getal = int(input("Geef een getal: "))
    lijst.append(getal)
kleinste = lijst[0]
for getal in lijst:
    if getal >= 0:
        positieve_lijst.append(getal)
    else:
        negatieve_lijst.append(getal)
        if getal < kleinste:
            kleinste = getal

print("lengte:",len(positieve_lijst),",", "getallen:",positieve_lijst)
print("lengte:",len(negatieve_lijst),",", "getallen:",negatieve_lijst)
print("kleinste getal:", kleinste)
