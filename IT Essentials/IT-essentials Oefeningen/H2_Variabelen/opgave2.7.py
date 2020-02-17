lengte = float(input("Geef de lengte van het tapijt: "))
breedte = float(input("Geef de breedte van het tapijt: "))

prijs_per_vierkante_meter = float(input("Geef de prijs per vierkante meter: "))
plaatsingskost = float(input("Geef de plaatsingskosten per vierkante meter: "))
prijs_tapijt = (lengte * breedte) * prijs_per_vierkante_meter
totale_plaatsingskost = (plaatsingskost * (lengte * breedte))

totale_kosten = (totale_plaatsingskost * prijs_tapijt)

print("De totale prijs van het tapijt is", prijs_tapijt,"De plaatsingskosten zijn: ", totale_plaatsingskost,
      'en de totale kosten zijn:', totale_plaatsingskost + prijs_tapijt)
