naam = input("Geef de naam van de manager: ")
geslaagd = 0
aantal = 0
while naam != "xx":
    aantal += 1
    test1 = (int(input("Geef het resultaat: ")))
    test2 = (int(input("Geef het resultaat: ")))
    test3 = (int(input("Geef het resultaat: ")))
    gemiddelde = round((test1 + test2 + test3) / 3, 1)
    if gemiddelde < 70:
        resultaat = "faalt"
    else:
        resultaat = "slaagt"
        geslaagd += 1
    print(naam, "Test1:", test1, "Test2:", test2, "Test3:", test3, "Gemiddelde:", gemiddelde, "Resultaat:", resultaat)
    naam = input("Geef de naam van de manager: ")

print("Er slaagden", geslaagd / aantal * 100, "% van de", aantal, "deelnemende managers.")
