def bereken_leeftijd(gebdatum, hdatum):
    lijst_gebdatum=gebdatum.split("/")
    leeftijd = int(hdatum[2])-int(lijst_gebdatum[2])
    if lijst_gebdatum[1] > hdatum[1] or int(lijst_gebdatum[1])==int(hdatum[1]) and int(lijst_gebdatum[0]) < int(hdatum[0]):
        leeftijd -= 1
    return leeftijd

def zet_om_sec(sec):
    uren = sec // 3600
    sec = sec % 3600
    min = sec // 60
    sec = sec % 60
    if sec >= 30:
        min += 1
        if min == 60:
            uren += 1
            min = 0
    return str(uren)+ " "+str(min)+"m"

def bereken_punten(juist,antwoord):
    punten = 20
    for i in range(len(antwoord)):
        if antwoord[i] == juist[i]:
            punten += 2
        elif antwoord[i] != "E":
            punten -= 1
    return 0
output = []
juist = input("Geef de juiste antwoorden in: ")
gegevens = input("Geef de gegevens v/e deelnemer in: ")
huidige_datum = input("Geef de datum in dd/mm/yyyy: ")
vandaag = huidige_datum.split("/")
teller = 0
while gegevens != "o":
    teller += 1
    lijst_gegevens = gegevens.split(" ")
    leeftijd = bereken_leeftijd(lijst_gegevens[1],vandaag)
    tijd = zet_om_sec(lijst_gegevens[3])
    punten = bereken_punten(juist,lijst_gegevens[2])
    output.append(str(teller)+".\t"+lijst_gegevens[0]+"\t"+str(leeftijd)+" jaar\t"+tijd+"\t"+str(punten)+"ptn")
    gegevens = input("Geef de gegevens v/e deelnemer in: ")

for lijn in output:
    print(lijn)

