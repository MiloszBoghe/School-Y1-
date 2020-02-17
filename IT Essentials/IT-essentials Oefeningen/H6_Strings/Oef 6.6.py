def oppervlakte_berekening(breedte,hoogte):
    oppervlakte = breedte * hoogte
    return oppervlakte

def gewicht_berekening(oppervlakte):
    gewicht = oppervlakte * 11
    return gewicht

def motor_berekening(gewicht):
    if gewicht < 150:
        motor = "A101"
    elif gewicht < 300:
        motor = "A105"
    else:
        motor = "X300"
    return motor

def motorprijs_berekening(motor):
    if motor == "A101":
        prijs = 120
    elif motor == "A105":
        prijs = 220.5
    else:
        prijs = 250.5
    return prijs

def poortprijs_berekening(oppervlakte, prijs_motor):
    prijs_poort = oppervlakte * 113.5 + prijs_motor
    return prijs_poort

def totaalprijs_berekening(prijs_poort, speciale_kleur):
    if speciale_kleur == "ja":
        totaalprijs = prijs_poort * 1.1
    else: totaalprijs = prijs_poort
    return totaalprijs

def offertenummer_functie(naam_verkoper, totaalprijs):
    totaalprijs = str(totaalprijs)
    offertenummer = "2018_"+naam_verkoper+"_"+ totaalprijs[-3::-1]
    return offertenummer.upper()

def prijsofferte_berekening(offertenummer, oppervlakte, gewicht, motor, totaalprijs):
    prijsofferte = "offertenummer:",offertenummer,"oppervlakte:", oppervlakte,"meter, gewicht:",\
                   gewicht,"kg, motor:", motor,"motor, totaalprijs:", totaalprijs, "euro"
    print(str(prijsofferte).replace("'","").replace(",","").replace("(","").replace(")",""))

def controle_hoogte(hoogte):
    return hoogte < 2 or hoogte > 6.5

def controle_breedte(breedte):
    return breedte < 2 or breedte > 8

naam_verkoper = input("Geef de naam van de verkoper: ")

hoogte = float(input("Geef de hoogte van de poort: "))
while controle_hoogte(hoogte) == True:
    hoogte = float(input("Fout. Geef een hoogte groter dan 2m en kleiner dan 6.5m: "))

breedte = float(input("Geef de breedte van de poort: "))
while controle_breedte(breedte) == True:
    breedte = float(input("Fout. Geef een breedte groter dan 2m en kleiner dan 8m: "))


speciale_kleur = input("Wil je een speciale kleur?(ja of nee): ")

oppervlakte = oppervlakte_berekening(breedte,hoogte)
gewicht = gewicht_berekening(oppervlakte)
motor = motor_berekening(gewicht)
prijs_poort = poortprijs_berekening(oppervlakte, gewicht)
totaalprijs = round(totaalprijs_berekening(prijs_poort, speciale_kleur),2)
offertenummer = offertenummer_functie(naam_verkoper, totaalprijs)

prijsofferte_berekening(offertenummer, oppervlakte, gewicht, motor, totaalprijs)

