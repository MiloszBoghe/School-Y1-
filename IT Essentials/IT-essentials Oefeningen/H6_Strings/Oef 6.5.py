def prijs_per_persoon(aantal_sterren,hotelcode):

    if hotelcode[:2] == "HI":
        res = 70
    elif aantal_sterren >= 4:
        res = 60
    elif aantal_sterren > 2:
        if hotelcode[:2] == "AN" or hotelcode[:2] == "BR":
            res = 60
        else:
            res = 56
    else:
        res = 48
    return res

def prijs_per_kind(kindercode, aantal_sterren, hotelcode, prijs):
    if kindercode == "A":
        if aantal_sterren < 3 or hotelcode[:2] != "BR":
            res = 0
        else:
            res = prijs / 2
    else:
        res = prijs / 2
    return res


volwassenen = int(input("Geef het aantal volwassenen: "))
kinderen = int(input("Geef het aantal kinderen: "))
hotelcode = input("Geef hotelcode: ")


while hotelcode != "/":
    aantal_sterren = int(input("Geef het aantal sterren: "))
    kindercode = input("Geef kindercode: ")
    prijs_volwassenen = prijs_per_persoon(aantal_sterren, hotelcode)
    prijs_kinderen = prijs_per_kind(kindercode, aantal_sterren, hotelcode, prijs_volwassenen)
    totaal = prijs_volwassenen + prijs_kinderen
    print(hotelcode + aantal_sterren * "*", prijs_volwassenen, prijs_kinderen, totaal)

    hotelcode = input("Geef hotelcode: ")
