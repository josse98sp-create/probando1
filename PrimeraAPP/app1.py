nota = int(input("Ingrese la nota (0-20): "))

if nota >= 11:
    print("Aprobado")
    if nota == 20:
        print("¡Excelente!")
else:
    print("Desaprobado")