tekst = "Barefoot on the grass, " \
        "# listening to our favourite song."
positie = tekst.find("#")
nieuw = tekst[positie + 1:].strip()
print(nieuw)