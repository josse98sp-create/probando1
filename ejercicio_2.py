num1 = float(input("Ingresa el primer número: "))
num2 = float(input("Ingresa el segundo número: "))

print("1=Suma, 2=Resta, 3=Multiplicación, 4=División")
opcion = int(input("Elige una opción: "))

match opcion:
    case 1:
        print("Resultado:", num1 + num2)
    case 2:
        print("Resultado:", num1 - num2)
    case 3:
        print("Resultado:", num1 * num2)
    case 4:
        if num2 == 0:
            print("Error: no se puede dividir entre 0")
        else:
            print("Resultado:", num1 / num2)
    case _:
        print("Opción no válida")