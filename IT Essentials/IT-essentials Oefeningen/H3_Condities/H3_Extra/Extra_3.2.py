leeftijd = int(input("Geef de leeftijd: "))
if leeftijd < 12:
    prijs = 6
elif leeftijd < 18:
    prijs = 12.5
else:
    prijs = 25
print("leeftijd: ", leeftijd, "prijs: ", prijs)