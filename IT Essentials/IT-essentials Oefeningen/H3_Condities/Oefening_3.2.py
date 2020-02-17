brutoloon = int(input("Geef het brutoloon: "))
jaarlijks_vakantiegeld = 0.05*brutoloon
if jaarlijks_vakantiegeld >= 350:
    jaarlijkse_bijdrage = 0.08*350
else:
    jaarlijkse_bijdrage = 0.08 * jaarlijks_vakantiegeld

print("Brutoloon = ",brutoloon, "vakantiegeld = ",jaarlijks_vakantiegeld, "jaarlijkse bijdrage = ",jaarlijkse_bijdrage)