tekst = input("Geef een tekst: ")
extra = input("Geef een tweede tekst: ")

while len(tekst) < 4:
    tekst = tekst[:len(tekst)] + "*"

while len(extra) < 4:
    extra = "+" + extra[:len(extra)]

nieuw = tekst[:4].upper() + extra[-4:].lower()
print(nieuw)


