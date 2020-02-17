lengte = float(input("Geef je lengte in m in "))
gewicht = float(input("Geef je gewicht in kg in "))
bmi = gewicht / lengte ** 2
if bmi < 18:
    print("ondergewicht")
elif bmi < 25:
    print("ok")
elif bmi < 30:
    print("overgewicht")
elif bmi < 40:
    print("obesitas")
else:
    print("ziekelijk overgewicht")