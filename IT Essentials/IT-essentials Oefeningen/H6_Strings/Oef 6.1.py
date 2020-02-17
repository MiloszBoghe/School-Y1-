tekst = input("Geef een tekst: ")
positie = tekst.lower().find("t")
if positie == -1:
    print("geen letter T in tekst")
else:
    if len(tekst) % 2 != 0:
        tekst = tekst[:positie] + tekst[positie:].upper()
    else:
        tekst = tekst[:positie] + tekst[positie:].lower()
    print(tekst)

