# Milosz Boghe - 1 TIN C

def score(word,name,base_score):
    for i in range(len(woord)):
        for j in range(len(name)):
            if word[i] == name[j]:
                base_score += ord(woord[i])* (j+1)
    return base_score

def totaalscore(month,food,base):
    if month == 1 and food == "N":
        base = base * 0.5 - 1050
    elif month == 1:
        base *= 0.5
    if month == 2 and food == "N":
        base = base * 2 - 1050
    elif month == 2:
        base *= 2
    else:
        base *= 3
    return base
from random import randint
naam = input("Wat is jouw naam?: ")
woord = "cinema"
hoogste_score = 0
winnaar = naam
while naam != "xxx" and naam != "qqq":
    geboortejaar = int(input("Wat is jouw geboortejaar?: "))
    maandbezoek = int(input("Hoe vaak per maand breng je een bezoek aan kinepolis (1 = weinig, 2 = matig, 3 = veel)?: "))
    snack = input("Wat koop je om te snacken in kinepolis (P = popcorn, C = chips, N = niets)?: ")
    basisscore = score(woord,naam,geboortejaar)
    print((naam)+":", "basisscore = ",basisscore)
    if hoogste_score < totaalscore(maandbezoek,snack,basisscore):
        hoogste_score = totaalscore(maandbezoek,snack,basisscore)
        winnaar = naam
    naam = input("Wat is jouw naam?: ")

random_getal = randint(1,9999)
while random_getal % 10 != 0 and random_getal < 5000 and random_getal % 2 != 0:
    print(random_getal)
    random_getal = randint(1,9999)
random_getalstring = str(random_getal)
prijs = 0
for i in range(len(random_getalstring)):
    prijs += int(random_getalstring[i])
print(winnaar,": Jij hebt gewonnen! \n"+"Jouw score is:", hoogste_score,"\n Het random gegenereerd getal is", random_getal,"\n", winnaar+", jij wint hierbij",prijs,"filmtickets")