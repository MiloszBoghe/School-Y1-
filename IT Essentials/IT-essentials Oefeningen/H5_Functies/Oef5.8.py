def kostprijs(vierkante_meter):
    prijs = int((vierkante_meter / 160)*12.5*100)/100
    return prijs

def personen(vierkante_meter):
    aantal = vierkante_meter // 1280
    return aantal

prijs_per_uur = 12.5
vierkante_meter = int(input("Geef het aantal schoon te maken m²: "))

while vierkante_meter != 0:
    extra = (vierkante_meter % 1280) / 160
    if extra < 1:
        minuten = extra * 60
        if minuten % 1 != 0:
            seconden = int((minuten % 1) * 60)
            minuten = int(minuten)
        extra = 0
    print("De prijs is:", kostprijs(vierkante_meter),"euro,", personen(vierkante_meter),
          "personen werken 8 uur,", "1 persoon werkt", extra,
          "uur,", minuten, "minuten en", seconden, "seconden" )
    vierkante_meter = int(input("Geef het aantal schoon te maken m²: "))
