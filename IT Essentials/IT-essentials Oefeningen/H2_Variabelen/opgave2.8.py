afgelegde_km = float(input("Hoeveel km rijd je per jaar? "))
verbruik = float(input("Hoeveel liter verbruikt je auto per 100km? "))
prijs_per_liter = float(input("Hoeveel kost 1 liter brandstof? "))
liter_per_km = 100 / verbruik
liter_per_jaar = afgelegde_km / liter_per_km
print("De totale kosten van het brandstof per jaar zijn", liter_per_jaar * prijs_per_liter)
print("De kosten per kilometer zijn", prijs_per_liter / liter_per_km)