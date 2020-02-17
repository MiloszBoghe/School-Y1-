tekst1 = input("geef een eerste tekst in: ")
tekst2= input("geef een tweede tekst in: ")

if len(tekst1) > len(tekst2):
    aantal =  len(tekst2)
else:
    aantal = len(tekst1)
for i in range(aantal):
    if tekst1[i] == tekst2[i]:
        print(tekst1[i], "op index", i)
