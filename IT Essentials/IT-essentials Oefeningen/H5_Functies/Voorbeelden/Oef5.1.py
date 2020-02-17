def print_regel(aantal,teken):
    for i in range(aantal):
        print(teken, end="")
    print()
def print_rechthoek(hoogte, breedte, teken):
    for rij in range(hoogte):
        print_regel(breedte,teken)

print_rechthoek(5,8,"+")
