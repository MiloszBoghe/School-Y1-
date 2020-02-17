from random import randint
aantal_getallen = int(input("Geef het aantal getallen dat random zal berekend worden: \n"))
veelvoud = int(input("geef een veelvoud: \n"))
getallenlijst = []
while aantal_getallen < 1:
    aantal_getallen = int(input("Geef het aantal getallen dat random zal berekend worden: \n"))

while veelvoud >= 10 or veelvoud <= 0:
    veelvoud = int(input("geef een veelvoud: \n"))

for i in range(aantal_getallen):
    grens = 100//veelvoud
    getal = randint(1,grens)*veelvoud
    getallenlijst.append(getal)

print("\nDe gegenereerde getallen zijn:", )
for getal in getallenlijst:
    print(getal,"\t", end="")

print("\n\nDe getallen kleiner dan het gemiddelde zijn: ")
for getal in getallenlijst:
    if getal < (sum(getallenlijst)/aantal_getallen):
        print(getal, "\t", end="")

print("\n\nDe array in speciale afdruk zijn: ")
if aantal_getallen % 2 != 0:
    for i in range(len(getallenlijst)-1,-1,-1):
        print(getallenlijst[i], "\t", end="")
    print()


