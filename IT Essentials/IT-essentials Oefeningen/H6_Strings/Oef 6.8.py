beginletter = input("Geef de beginletter: ").upper()
rijen = int(input("Geef het aantal rijen: "))

for i in range(1,rijen+1):
    for j in range(i):
        if ord(beginletter) > ord("Z"):
            beginletter = "A"
        print((beginletter),end="")
        beginletter = chr(ord(beginletter)+1)
    print()