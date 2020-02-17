getallenlijst = [154, 23, 3024, 432, 554, 6321, 75, 854, 913]
grootste = getallenlijst[0]
kleinste = getallenlijst[0]
i = 0
for i in range(len(getallenlijst)):
    print(getallenlijst[i])
    if getallenlijst[i]>grootste:
        grootste = getallenlijst[i]
    elif getallenlijst[i] < kleinste:
        kleinste = getallenlijst[i]
    i += 1
print()
print("grootste:", grootste)
print("kleinste:", kleinste)

som = 0
for getal in getallenlijst:
    som += getal
print("Som:", som)


print("het grootste getal is:", max(getallenlijst))
print("het kleinste getal is:", min(getallenlijst))
print("de som is:", sum(getallenlijst))