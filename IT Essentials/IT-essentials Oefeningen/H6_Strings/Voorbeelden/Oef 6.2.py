#meter => voet// 1 meter = 3.2808399 voet
print("{:^15} {:^15}".format("meter", "voet"))
for meter in range(2, 41):
    meter /= 2
    voet = meter * 3.2808399
    print("{:^15.2f} {:^15.2f}".format(meter,voet))