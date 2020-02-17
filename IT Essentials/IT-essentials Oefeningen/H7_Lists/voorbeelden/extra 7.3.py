from random import randint
list_tel = 7 * [0]
weekdagen = ["maandag", "dinsdag", "woensdag", "donderdag", "vrijdag", "zaterdag", "zondag"]
for i in range(2489):
    getal = randint(0, 6)
    list_tel[getal] += 1
for getal in range(7):
   print("procentueel aandeel van {} is {:.2f}".format(weekdagen[getal], list_tel[getal] / 2489 * 100))