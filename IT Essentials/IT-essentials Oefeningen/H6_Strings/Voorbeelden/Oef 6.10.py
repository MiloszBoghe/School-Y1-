# tekst omzetten naar hoofdletters zonder gebruik te maken van de methode upper
tekst = input("Geef een tekst in: ")
nieuw = ""
for letter in tekst:
    if letter.islower():
        nieuw += chr(ord(letter) - 32)
    else:
        nieuw += letter

print(nieuw)