burgerlijke_staat = input("Geef je burgerlijke staat in: ")
leeftijd = int(input("Geef de leeftijd in : "))
if burgerlijke_staat == 1:
    lidgeld = 25
elif burgerlijke_staat == 2 and leeftijd < 30:
    lidgeld = 20
else: lidgeld = 15
print("het lidgeld bedraagt", lidgeld, "euro")



