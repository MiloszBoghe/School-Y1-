def cumulative_sum(getal):
    for i in range(1,len(getallenlijst)):
        getallenlijst[i] = getallenlijst[i-1] + getallenlijst[i]
    return getallenlijst

getallenlijst = [1, 2, 3, 4, 5, 6, 7, 8, 9]

print(cumulative_sum(getallenlijst))
