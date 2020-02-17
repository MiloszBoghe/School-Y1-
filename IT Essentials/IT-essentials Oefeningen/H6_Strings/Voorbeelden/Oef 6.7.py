spreuk = "abracadabra"
count = 0
spreuk = spreuk.replace("a", "o")

#methode 1
print(spreuk,"\n",spreuk.count("o"),"o's".strip())

#methode 2 mbv methode find
positiie = spreuk.find("o")
teller = 0
while positiie != -1:
    teller += 1
    positiie = spreuk.find("o", positiie + 1)
print(teller, "o's")

#methode 3 (minst goede)
for i in range(len(spreuk)):
    if spreuk[i] == "o":
        count+=1
print(count, "o's")