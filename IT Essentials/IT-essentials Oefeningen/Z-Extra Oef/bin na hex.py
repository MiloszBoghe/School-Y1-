def berekening(teken):
    if teken == 10:
        waarde = "A"
    elif teken == 11:
        waarde = "B"
    elif teken == 12:
        waarde = "C"
    elif teken == 13:
        waarde = "D"
    elif teken == 14:
        waarde = "E"
    elif teken == 15:
        waarde = "F"
    else:
        waarde = int(teken)
    return waarde


def splitsen(waarde):
    waarde = waarde.split(" ")
    return waarde

list= ["0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111"]
listgetal = []
listkomma = [","]
binair = input("Geef de binaire code: ")

if "." in binair:
    binair = binair.split(". ")
    getal = binair[0]
    komma = binair[1]
    getal = splitsen(getal)
    komma = splitsen(komma)

    for i in range(len(getal)):
        waarde = list.index(getal[i])
        waarde = berekening(waarde)
        listgetal.append(waarde)

    for j in range (len(komma)):
        waarde = list.index(komma[j])
        waarde = berekening(waarde)
        listkomma.append(waarde)

    listgetal = listgetal + listkomma

    for e in range (len(listgetal)):
        print(listgetal[e], end= "")
else:
    binair = splitsen(binair)
    for i in range(len(binair)):
        waarde = list.index(binair[i])
        waarde = berekening(waarde)
        print(waarde, end="")


