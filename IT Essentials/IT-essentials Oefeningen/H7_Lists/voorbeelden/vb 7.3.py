getallenlijst = []


getal = int(input("geef getal, 0 om te stoppen: "))
while getal != 0:
    if getal not in getallenlijst:
        getallenlijst.append(getal)
    else:
        print(getal, "komt voor op plaats", getallenlijst.index(getal))
        getallenlijst.remove(getal)
    getal = int(input("Geef een getal, 0 om te stoppen: "))

print(getallenlijst)