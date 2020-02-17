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

list = []
listkomma = []
decimaal = input("geef een getal: ")
if "." in decimaal:
    decimaal = decimaal.split(".")
    getal = decimaal[0]
    komma = decimaal[1]
    getal = int(getal)
    komma = float(komma) / 10**(len(komma))

    while getal != 0:
        boven = getal // 16
        onder = (getal / 16 - boven) * 16
        onder = berekening(onder)
        list.append(str(onder))
        getal = boven

    teller = 0
    while teller != 4 and komma != 0:
        get = komma * 16
        get = str(get)
        get = get.split(".")
        komma = get[1]
        komma = float(komma) / 10**(len(komma))
        get = berekening(int(get[0]))
        listkomma.append(get)
        teller += 1

    listkomma.insert(0, ",")
    list = list[-1::-1] + listkomma
    for i in range (len(list)):
        print(list[i], end="")
else:
    decimaal = int(decimaal)
    while decimaal != 0:
        boven = decimaal // 16
        onder = (decimaal / 16 - boven) * 16
        onder = berekening(onder)
        list.append(str(onder))
        decimaal = boven
    list = list[-1::-1]
    for i in range (len(list)):
        print(list[i], end="")