n = int(input("Geef een getal: "))
som = 0
for i in range(n):
    karakter = input("Geef een karakter: ")
    if karakter.isalnum():
        if karakter.isupper():
            print(karakter,"is een hoofdletter")
        elif karakter.islower():
            print(karakter,"is geen hoofdletter")
        else:
            karakter = int(karakter)
            som += karakter
    else:
        print("onbekend")
print("De som van de karakters die getallen waren is", som)

