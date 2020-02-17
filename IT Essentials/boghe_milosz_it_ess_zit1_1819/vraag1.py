# Milosz Boghe - 1 TIN C
def s_producten(lijst):
    print("Lijst van de bij te bestellen producten:\n", lijst, "\n")

def a_producten(lijst):
    print("Lijst van de actie artikelen:\n", lijst)

artikels = ["S-kaftE34-5-100", "S-DVD345-1-124", "A-penD34-125", "S-boekX33-3-256", "A-bal34-145", "S-boekZ34-2-26", "A-ballon34-15"]
artikellijst = []
s_bijbestellen = []
a_artikels = []
for i in range(len(artikels)):
    artikellijst.append(artikels[i].split("-"))

for i in range(len(artikels)):
    aantal = int(input("Geef het aantal artikels in voorraad: "))
    if artikels[i][0] == "A":
        while aantal > int(artikellijst[i][2]):
            aantal = int(input("Fout, zoveel artikels kunnen niet in voorraad zijn! Opnieuw: "))
        artikellijst[i][2] = str(aantal)
        if aantal > 0:
            a_artikels.append(artikellijst[i])

    if artikellijst[i][0] == "S" and aantal < int(artikellijst[i][3]):
        nodig = int(artikellijst[i][3]) - aantal
        s_bijbestellen.append("Product "+ artikels[i] + " te bestellen: "+str(nodig)+ " stuks")

s_producten(s_bijbestellen)
a_producten(a_artikels)