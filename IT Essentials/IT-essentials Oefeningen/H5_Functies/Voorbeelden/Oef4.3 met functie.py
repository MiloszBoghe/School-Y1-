def print_driehoek(grootte):
    for rij in range(1, grootte + 1):
        for kolom in range(1, grootte + 2, -rij):
            print(kolom, "\t", end= "")
        print()

def bereken_som(grootte):
    som = 0
    for rij in range (grootte, +1):
        for kolom in range(1, grootte+2, rij):
            som=som+kolom
    return som
