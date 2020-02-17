def betpaal_vervoer(code):
    if code == 1:
        vervoer = "met de bus"
    elif code == 2:
        vervoer = "te voet"
    elif code == 3:
        vervoer = "met de trein"
    else:
        vervoer = "met de auto"
    return vervoer

teller_auto = 0
minumum = 3600 #Hoog getal omdat het altijd lager gaat zijn, Grote waarde om kleinste getal zeker te vinden.
teller = 0
som = 0
code = int(input("Geef de code in, code:1 = met de bus, 2 = te voet, 3 = met de trein, 4 = met de auto en 0 om te eindigen "))

while code != 0:
    if code >= 1 and code <= 4:
        tijd = int(input("Geef de tijd in minuten "))
        som = som + tijd
        teller +=1
        if tijd < minumum:
            minumum = tijd
            minimum_vervoer = code
        if code == 4:
            teller_auto += 1
    else:
        print("Foute code! opnieuw")
        code = int(input("Geef de code in, code:1 = met de bus, 2 = te voet, 3 = met de trein, 4 = met de auto en 0 om te eindigen "))

if teller == 0: #als je het allereerste cijfer een nul geeft
    print("Geen gegevens ingegeven")
else:
    gemiddelde = som / teller
    print("De gemiddelde duur is ", gemiddelde)
    print("De kleinste tijd is ", minimum, "minuten")
    print("de kleinste tijd is ", minumum, "minuten")

print("Dit was ", vervoer(minimum_vervoer))
percentage = teller_auto / teller * 100
print("Het percentage dat met de auto komt is ", percentage)