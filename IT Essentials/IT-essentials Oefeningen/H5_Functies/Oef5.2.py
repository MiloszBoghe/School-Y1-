def schrikkeljaar(jaar):
    if jaar % 100 == 0 and jaar % 400 != 0:
        res = False
    else:
        res = (jaar % 4 == 0)
    return res

datum = input("Geef een datum in dd/mm/jjjj: ")
dagen_list = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]
datum_geg = datum.split("/")
som = 0
for i in range(int(datum_geg[1]) - 1):
    som += dagen_list[i]
if schrikkeljaar(int(datum_geg[2])) and int(datum_geg[1]) > 2:
    som += 1
som += int(datum_geg[0])

print(datum, "is op dagnummer", som)