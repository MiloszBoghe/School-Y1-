aantal = int(input("Hoeveel artikels wilt u bestellen? "))
bedrag = aantal * 11.5 * 1.21
if bedrag > 1000:
    bedrag = bedrag * 0.9
print("Het bedrag is: ", int(bedrag * 100) / 100)
