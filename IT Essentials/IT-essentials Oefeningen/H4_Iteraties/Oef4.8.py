afstand = 36
inschrijvingsnummer = int(input("geef het inschrijvingsnummer: "))
tijd = int(input("tijd in seconden: "))
langer_dan_uur = 0
snelste_tijd = tijd
teller = 0
while inschrijvingsnummer >= 0:
    teller += 1
    if tijd >=3600:
        langer_dan_uur += 1
    if tijd < snelste_tijd:

        snelste = inschrijvingsnummer
    inschrijvingsnummer = int(input("geef het inschrijvingsnummer: "))
    tijd = int(input("tijd in seconden: "))
print("De snelste renner is de renner met inschrijvingsnummer: ", snelste, "in", snelste_tijd, "seconden")
print("Het percentage van de renners dat er langer dan 1 uur over doet is",langer_dan_uur/teller*100 )
