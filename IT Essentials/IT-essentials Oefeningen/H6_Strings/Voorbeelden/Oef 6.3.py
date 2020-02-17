tekst = "Dit is een tekst met een heleboel klinkers."
for i in range(len(tekst)):
    if tekst[i] in "aeiou":
        print(tekst[i], "op positie",i)
