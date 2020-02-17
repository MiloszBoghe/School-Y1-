examen1 = int(input("Resultaten examen 1 (0-20): "))
examen2 = int(input("Resultaten examen 2 (0-20): "))
examen3 = int(input("Resultaten examen 3 (0-20): "))

percentage_student = (examen1 + examen2 + examen3) / 60 * 100
if percentage_student >= 90:
    behaalde_graad = "Grootste onderscheiding"
elif percentage_student >= 80:
    behaalde_graad = "Grote onderscheiding"
elif percentage_student >= 70:
    behaalde_graad = "Onderscheiding"
elif percentage_student >= 60:
    behaalde_graad = "Voldoende"
else:
    behaalde_graad = "Onvoldoende"
print("De student behaalde: ", percentage_student, "%", behaalde_graad )
