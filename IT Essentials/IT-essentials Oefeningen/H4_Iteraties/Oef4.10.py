breedte = int(input("Geef een breedte: "))
hoogte = breedte
for breedte in range (breedte,0, -1):
    for hoogte in range (breedte):
        print("a ", end="")
    print()
