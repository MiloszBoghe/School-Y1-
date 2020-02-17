neerslag = input("Geef de hoeveelheid neerslag (overvloed, veel, matig, geen): ")
dagen = 7
templist = []
neerslagen = []
laagste = 50
som = 0
veel = False
while dagen != 0 and neerslag != "overvloed":
    dagen -= 1
    temperatuur = int(input("Geef de temperatuur (gehele getallen): "))
    templist.append(temperatuur)
    neerslagen.append(neerslag)
    if temperatuur < laagste:
        laagste = temperatuur
    som += temperatuur
    if neerslag == "veel":
        veel = True
    neerslag = input("Geef de hoeveelheid neerslag (overvloed, veel, matig, geen): ")
print("dag\ttemperatuur\tneerslag")
for i in range(len(templist)):
    print(i+1,"\t\t", templist[i], "\t", neerslagen[i])
if neerslag == "overvloed":
    print("We blijven thuis.")
else:
    gemiddelde = som/len(templist)
    if not veel and laagste >= 15 and laagste > 0.2 * gemiddelde:
        print("we gaan op 2daagse")
    else:
        print("We gaan op daguitstap")