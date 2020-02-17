burgerlijke_staat = input("Geef je burgerlijke staat in: ")
leeftijd = int(input("Geef de leeftijd in : "))
if burgerlijke_staat == 1 and leeftijd < 30:
    lidgeld = 25
else:
    lidgeld = 15
print("het lidgeld bedraagt", lidgeld, "euro")



