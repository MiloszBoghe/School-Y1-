personeelsnummer = int(input("geef je personeelsnummer: "))
aantal_m = 0
aantal_f = 0
while personeelsnummer != 0:
    geslacht = int(input("Geef 0 of 1 (0 = vrouw, 1 = man: "))
    while (geslacht != 0 and geslacht != 1):
        print("foutieve invoer")
        geslacht = int(input("Geef 0 of 1 (0 = vrouw, 1 = man: "))
    leeftijd = int(input("Geef je leeftijd: "))
    brutoloon = int(input("Geef je brutoloon: "))
    if geslacht == 1:
        if  (leeftijd > 33 or brutoloon > 1799):
             aantal_m += 1
    elif  leeftijd < 25:
        aantal_f += 1
    personeelsnummer = int(input("geef je personeelsnummer: "))
print("Het aantal mannelijke personen die ofwel ouderz ijn dan 34 jaar, of een loon hebben van"
      " 1800 euro of meer: ", aantal_m, "\n" "vrouwen jonger dan 25: ", aantal_f)