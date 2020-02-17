from random import randint
def tel_index_list(list, element):
    print(element, "komt", list.count(element), "keer voor")
    teller = list.count(element)
    positie = -1
    for i in range(teller):
        positie = list.index(element, positie + 1)
        print("op index", positie)

lijst = []
for i in range(100):
    getal = randint(0, 9)
    lijst.append(getal)
invoer = int(input("Geef een getal >=0 en <10 in: "))
while invoer > 9 or getal < 0:
    invoer = int(input("fout, geef opnieuw getal in, maar deze keer geldig"))
tel_index_list(lijst, invoer)


