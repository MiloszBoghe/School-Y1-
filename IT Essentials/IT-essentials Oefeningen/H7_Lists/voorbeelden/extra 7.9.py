def get_number_of_participants(list):
    return len(list[0])

def get_number_of_tests(list):
    return len(list)

def highest_heart_rate(list):
    grootste = list[0][0]
    for i in range(len(list)):
        for j in range(len(list[i])):
            if grootste < list[i][j]:
                grootste = list[i][j]
    return grootste

def lowest_heart_rate(list):
    kleinste = list[0][0]
    for i in range(len(list)):
        klrij = min(list[i])
        if kleinste > klrij:
            kleinste = klrij
    return kleinste
def average_heartrate(list):
    average = []
    for i in range(len(list)):
        som = sum(list[i])
        average.append(som/len(list[i]))
    return average

def heartrate_difference(list):
    difference = []
    for j in range(len(list[0])):
        kl = list[0][j]
        gr = list[0][j]
        for i in range(1, len(list)):
            if list[i][j] > gr:
                gr = list[i][j]
            elif list[i][j] < kl:
                kl = list[i][j]
        difference.append(gr-kl)
    return difference


list = [[72, 85, 62, 12, 32, 54],
        [32, 84, 54 ,61 ,32 ,54],
        [45, 78, 96, 62, 31, 13],
        [11, 18, 29, 39, 28, 49]]

print("aantal deelnemers:", get_number_of_participants(list))
print("aantal testen:", get_number_of_tests(list))
print(highest_heart_rate(list))
print(lowest_heart_rate(list))
print(average_heartrate(list))
print(heartrate_difference(list))