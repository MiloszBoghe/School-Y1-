decimaal = input("Geef een getal: ")
volledig = decimaal
binair = [0]
binair_komma = []
if "." in decimaal:
    decimaal = decimaal.split(".")
    geheel = int(decimaal[0])
    komma = int(decimaal[1])
    komma = komma / 10 ** len(decimaal[1])
    while komma != 0 and len(binair_komma) < 10:
        komma *= 2
        binair_komma.append(int(komma // 1))
        if komma >= 1:
            komma -= 1
else:
    geheel = int(decimaal)

while geheel != 0:
    if (geheel % 2) == 0:
        binair.append(0)
    else:
        binair.append(1)
    geheel = geheel // 2

binair = binair[len(binair):0:-1]
print("De binaire voorstelling van getal",volledig,"is",str(binair).replace(",", "").replace("[", "").replace("]", "").replace(" ", "") + "." + str(binair_komma).replace(
    ",", "").replace("[", "").replace("]", "").replace(" ", ""))
