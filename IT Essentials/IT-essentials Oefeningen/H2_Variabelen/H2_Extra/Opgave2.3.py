diameter_inch = int(input("Geef de diameter in inch: "))
afstand = int(input("Geef de afstand in meter: "))

afstand_per_omwenteling = diameter_inch * 3.14 * 0.0254
aantal_omwentelingen_nodig = afstand / afstand_per_omwenteling

print(round(aantal_omwentelingen_nodig,2))