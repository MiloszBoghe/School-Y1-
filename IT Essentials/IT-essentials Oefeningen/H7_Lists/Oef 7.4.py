list = []
text = input("Geef een tekst: ")
text = text.lower()

for letter in text:
    if ord(letter) >= ord("a") and ord(letter) <= ord("z"):
        list.append(letter)
list.sort()
teller = 1
for letter in list:
    while list.count(letter) > 1:
        list.remove(letter)
        teller += 1
    print(letter,"komt", teller, "keer voor")
    teller = 1



