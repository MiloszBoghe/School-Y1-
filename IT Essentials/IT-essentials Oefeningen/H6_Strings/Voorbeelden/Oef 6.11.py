for rij in range(32,48):
    for kol in range(6):
        ascii = rij + 16 * kol
        print("{:>3} {:<3}".format(ascii,chr(ascii)),end="")
    print()