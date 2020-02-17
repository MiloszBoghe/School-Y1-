naam = input("geef de naam: ")



while naam.upper() != "XX":
    percentage = int(input("Geef het percentage: "))
    while percentage < 0 or percentage > 100:
        if percentage < 0:
            percentage = int(input("Fout! Percentage moet groter dan 0 zijn, voer opnieuw in: "))
        else:
            percentage = int(input("Fout! Percentage mag max 100 zijn. Voer percentage in: "))
    if percentage < 60:
        graad = "Onvoldoende"
    elif percentage < 70:
        graad = "Voldoende"
    elif percentage < 80:
        graad = "Onderscheiding"
    elif percentage < 85:
        graad = "Grote onderscheiding"
    else:
        graad = "Grootste onderscheiding"
    print("Naam:", naam, "\nPercentage:",percentage,"%\nGraad:",graad)
    naam = input("geef de naam: ")

