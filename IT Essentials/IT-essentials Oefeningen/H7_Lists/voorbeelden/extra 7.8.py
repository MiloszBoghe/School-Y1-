

lijst = []
for rijnr in range(1, 5):
    rij = []
    for kolnr in range(1, 7):
        rij.append(rijnr*kolnr)
    lijst.append(rij)

for i in range(len(lijst)):
    print(lijst[i])


for j in range(6):
    som = 0
    for i in range(4):
        som += lijst[i][j]
    print(som)

for i in range(4):
    som = 0
    for j in range(6):
        som += lijst[i][j]
    print("De som van rij", i + 1, "=", som)

#alternatief

for i in range(4):
    print("De som van rij", i + 1, "=", sum(lijst[i]))
