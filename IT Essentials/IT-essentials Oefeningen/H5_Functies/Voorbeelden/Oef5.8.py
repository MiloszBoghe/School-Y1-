def bereken_belasting(inkomen):
    if inkomen <= 25000:
        belasting = 0.384 * inkomen
    else:
        belasting = 25000 * 0.384
        if inkomen <= 55000:
            belasting += 0.5*(inkomen-25000)
        else:
            belasting += 0.5 * 30000 + 0.6 * (inkomen-55000)

