def converteer(euro):
    return euro * waarde_euro_in_dollar

euro = float(input("Geef het aantal euro: "))
waarde_euro_in_dollar = float(input("Geef de waarde van euro t.o.v. dollar: "))
while euro != 0:
    print(converteer(euro))
    euro = float(input("Geef het aantal euro: "))



