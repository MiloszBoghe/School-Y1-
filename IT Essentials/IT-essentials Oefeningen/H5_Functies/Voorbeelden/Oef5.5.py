def is_even(getal):
    return getal % 2 == 0

def is_oneven(getal):
    return not is_even(getal)

print(is_oneven(55))
print(is_oneven(54))