getal = int(input("geef een getal: "))
while getal <= 1 or getal >= 100:
    if(getal >= 100):
        print("Fout! Het getal moet kleiner zijn dan 100")
    else:
        print("Fout! Het getal moet groter dan 1 zijn")
    getal = int(input("geef een getal: "))
print("Het getal is: ", getal)