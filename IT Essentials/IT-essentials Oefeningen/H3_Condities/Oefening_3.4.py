getal_a = float(input("geef een getal: "))
getal_b = float(input("geef een tweede getal: "))

if getal_a == 0 or getal_b == 0:
    print("Het kleinste getal is 0", "Het kwadraat is 0", "Kan niet delen door 0")
elif getal_a > getal_b:
    print("Het kleinste getal is ", getal_b, "Het kwadraat is ", getal_b ** 2)
else:
    print("Het kleinste getal is ", getal_a, "Het kwadraat is ", getal_a ** 2)
