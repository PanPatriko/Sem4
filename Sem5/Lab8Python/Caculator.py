while True:
    print("===Kalkulator===")
    print("1.Dodawanie")
    print("2.Odejmowanie")
    print("3.Mnozenie")
    print("4.Dzielenie")
    print("5.Potegowanie")
    print("6.Wyjscie")

    value = input("Wybierz dzialanie")
    try:
        value = int(value)
    except ValueError:
        print("Niepoprawna wartosc")
        continue
    if value < 1 or value > 6:
        print("Niepoprawny zakres[1-6]")
        continue

    if value == 6:
        break

    a = input("Podaj pierwsza liczbe:")
    b = input("Podaj druga liczbe:")

    try:
        a = float(a)
        b = float(b)
    except ValueError:
        print("Niepoprawna wartosc")
        continue

    if value == 1:
        print(a.__str__()+" + "+b.__str__()+" = "+(a+b).__str__())
    elif value == 2:
        print(a.__str__()+"-"+b.__str__()+" = "+(a-b).__str__())
    elif value == 3:
        print(a.__str__()+" * "+b.__str__()+" = "+(a*b).__str__())
    elif value == 4:
        print(a.__str__()+" / "+b.__str__()+" = "+(a/b).__str__())
    elif value == 5:
        print(a.__str__()+" ** "+b.__str__()+" = "+(a**b).__str__())

