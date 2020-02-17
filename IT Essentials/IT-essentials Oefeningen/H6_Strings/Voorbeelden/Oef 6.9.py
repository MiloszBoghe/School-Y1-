tekst = input("geef een tekst in: ")
nieuw = ""
for letter in tekst:
    #if ord(letter) >= ord("a") and ord(letter) <= ord("z"):
     #   nieuw += letter
    #else:
        #nieuw += " "
    if letter.islower():
        nieuw += letter
    else:
        nieuw += " "
print(nieuw)
