"""
bedrag = int(input("Hoeveel centen? "))
twee_euro = bedrag // 200
bedrag = bedrag % 200
een_euro = bedrag // 100
bedrag = bedrag % 100
vijftig_cent = bedrag // 50
bedrag = bedrag % 50
twintig_cent = bedrag // 20
bedrag = bedrag % 20
tien_cent = bedrag // 10
bedrag = bedrag % 10
vijf_cent = bedrag // 5
bedrag = bedrag % 5
twee_cent = bedrag // 2
bedrag = bedrag % 2
een_cent = bedrag // 1

print(twee_euro, "X 2 euro", een_euro, "X 1 euro", vijftig_cent, "X 50 cent", twintig_cent, "X 20 cent", tien_cent,
      "X 10 cent", vijf_cent, "X 5 cent", twee_cent, "X 2 cent", een_cent, "X 1 cent")
"""

muntenlijst = [200, 100, 50, 20, 10, 5, 2, 1]
tellerlijst = []
namenlijst = ["2 euro", "1 euro", "50 cent", "20 cent", "10 cent", "5 cent", "2 cent", "1 cent" ]
bedrag = int(input("geef een bedrag: "))
for munt in muntenlijst:
    tellerlijst.append(bedrag//munt)
    bedrag = bedrag % munt

for i in range(len(namenlijst)):
    if tellerlijst[i] != 0:
        print(tellerlijst[i], "munten van", namenlijst[i])