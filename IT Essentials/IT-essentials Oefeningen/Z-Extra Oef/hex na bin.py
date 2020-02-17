def berekening(teken):
    if teken == "A":
        waarde = 10
    elif teken == "B":
        waarde = 11
    elif teken == "C":
        waarde = 12
    elif teken == "D":
        waarde = 13
    elif teken == "E":
        waarde = 14
    elif teken == "F":
        waarde = 15
    else:
        waarde = teken
    return waarde

list= ["0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111"]
listgetal = []
listkomma = [","]
hex = input("Geef de hexadecimale code: ")
hex = hex.upper()

if '.' in hex:
    hex = hex.split(".")
    getal = hex[0]
    komma = hex[1]
    for i in range (0, len(getal)):
        waarde = berekening(getal[i])
        code = list[int(waarde)]
        listgetal.append(code)


    for j in range (0, len(komma)):
        waarde = berekening(komma[j])
        code = list[int(waarde)]
        listkomma.append(code)

    listgetal += listkomma
    for e in range (len(listgetal)):
        print(listgetal[e], end=" ")
else:
    for i in range (0, len(hex)):
        waarde = berekening(hex[i])
        code = list[int(waarde)]
        listgetal.append(code)
    for e in range (len(listgetal)):
        print(listgetal[e], end=" ")