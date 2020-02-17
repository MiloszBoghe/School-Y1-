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
    return int(waarde)

hex = input("Geef de hexadecimale waarde: ")
hex = hex.upper()
lijst1 = []
lijst2 = []
gehelesom = 0
kommagetal = 0
teller = 0
if "." in hex:
    hex = hex.split(".")
    getal = hex[0]
    komma = hex[1]


    for i in range(len(getal),0,-1):
        gehelesom += int(berekening(getal[i-1]))*16**teller
        teller += 1
    print("geheel getal:",gehelesom)

    teller = len(komma)
    for i in range(len(komma),0,-1):
        kommagetal += int(berekening(komma[i-1]))/16**teller
        teller -= 1
    print("kommagetal:",kommagetal)

    getal = gehelesom + kommagetal
    print("uitkomst:",getal)
else:
    for i in range(len(hex),0,-1):
        gehelesom += int(berekening(hex[i-1]))*16**teller
        teller += 1
    print("uitkomst:", gehelesom)


