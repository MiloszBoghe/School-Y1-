stemmen = []
namen = ["An Janssen", "Bart Vriends", "Andries Michels", "Inge Kaas"]
keuze = int(input("Geef je stem(1-4): "))

while keuze != 0:
    stemmen.append(keuze)
    keuze = int(input("Geef je stem(1-4): "))

for i in range(1,len(namen)+1):
    print(namen[i-1], stemmen.count(i),"stemmen (","{:.1f}%)".format(stemmen.count(i) / len(stemmen) * 100))