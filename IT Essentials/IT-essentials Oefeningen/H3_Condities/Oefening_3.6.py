jaar = int(input("Geef het jaar van de film: "))
rating = int(input("Geef de rating (1-5): "))
prijs = 5
if jaar >= 2016:
        prijs += 2
if rating >= 4 and prijs <7:
    prijs += 2
elif rating > 1 and prijs < 7:
    prijs += 1

print(prijs)
