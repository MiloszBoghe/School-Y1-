getal_a = int(input("Geef een getal: "))
getal_b = int(input("Geef een getal: "))
bewerkingscode = int(input("Geef een getal van 1-5: "))

if bewerkingscode < 1 or bewerkingscode > 5:
    print("Foutieve code")
else:
    if bewerkingscode == 1:
         resultaat = getal_a + getal_b
    elif bewerkingscode == 2:
        resultaat = getal_a - getal_b
    elif bewerkingscode == 3:
        resultaat = getal_a * getal_b
    elif bewerkingscode == 4:
         resultaat = getal_a ** 2
    else:
        resultaat = getal_b ** 2

    print ("Getal 1: ", getal_a, "Getal 2:", getal_b, "Resultaat: ", resultaat)
