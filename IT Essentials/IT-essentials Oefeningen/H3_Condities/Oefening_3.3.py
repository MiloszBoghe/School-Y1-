tijd_u = int(input("Geef het uur: "))
tijd_m = int(input("Geef de minuut: "))
duur = int(input("Geef de duur van de vlucht in minuten: "))

totale_minuten = 60 * tijd_u + tijd_m + duur
aankomst_uur = (totale_minuten // 60) % 24
aankomst_minuut = totale_minuten % 60
print("aankomst uur: ", aankomst_uur, "aankomst_minuut: ", aankomst_minuut)