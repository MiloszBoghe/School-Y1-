binair_list = []
binair_list[0] = input("geef een binair getal: ")

if ',' in binair:
    binair_list = binair.split(',')
else:
    for i in range(len(binair)):
        binair_list.append(int(binair[i]))
        decimaal = binair_list[0]

    for i in range(1,len(binair_list)):
        decimaal = (decimaal * 2) + binair_list[i]
        print(decimaal)
