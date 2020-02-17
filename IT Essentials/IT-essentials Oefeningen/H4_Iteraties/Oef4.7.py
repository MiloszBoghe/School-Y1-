som = 0
max_temp = -100
for i in range(10):
    temperatuur = float(input("Geef de temperatuur: "))
    som += temperatuur

    if(temperatuur > max_temp):
        max_temp = temperatuur
print("De hoogste temperatuur was: ",max_temp, "De gemiddelde temperatuur was", som/10);
