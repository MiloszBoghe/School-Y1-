woord = input("geef een woord: ")

if len(woord) % 2 == 0:
    mid = len(woord)//2 - 1
    deel2 = woord[mid:mid + 2]
    deel3 = woord[mid + 2:]

else:
    mid = len(woord) // 2
    deel2 = woord[mid]
    deel3 = woord[mid + 1:]
deel1 = woord[0:mid]
nieuw_woord = deel1+deel2.upper()+deel3
print(nieuw_woord)