def ZetOmNaarRomeinsCijfer(getal, romeins, cijfer):
    uitkomst = 0
    for i in range(len(waarde)):
        aantal = getal // waarde[i]
        getal = getal % cijfer[i]
        uitkomst += aantal * romeins[i]
    return uitkomst


from random import randint
roman = ["XL", "X", "IX", "V", "IV", "I"]
waarde = [40, 10, 9, 5, 4, 1]
tekst = ["minder dan 50", "tussen 50 en 70", "tussen 70 en 90", "van 90 of meer"]
letter = input("Geef letter: ").lower()

for ascii in range(ord("a"), ord(letter) + 1):
    print("Reeks", chr(ascii))
    getal1 = randint(1, 49)
    print("Het romeinse cijfer voor", getal1, "is", ZetOmNaarRomeinsCijfer(getal1,roman,waarde))
    getal2 = randint(1, 49)
    while getal2 > getal1:
        getal1 = getal2
        print("Het romeinse cijfer voor", getal1, "is", ZetOmNaarRomeinsCijfer(getal1, roman, waarde))
        getal2 = randint(1, 49)

