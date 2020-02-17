"""
Geef een getal in. Ga na of dit getal kleiner is dan 10, tussen 10 en 100 is (grenzen inbegrepen) of groter is dan 100.
Druk een gepaste foutmelding af.
"""
getal = int(input("Geef een getal: "))
if getal < 10:
    print("het getal is kleiner dan 10")
elif getal <= 100:
    print("het getal ligt tussen 10 en 100")
else: print("getal > 100")
