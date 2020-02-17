voornaam = input("Geef een voornaam: ").strip()
achter = input("geef een achternaam: ").strip()
eerst_voor = voornaam[0].upper()
eerst_achter = achter[0].upper()
rest_achter = achter[1:].lower()

nieuw = eerst_voor + ". " + eerst_achter + rest_achter
print(nieuw)