peso = float(input("Ingresa tu peso (kg): "))
altura = float(input("Ingresa tu altura (m): "))

imc = peso / (altura ** 2)

print(f"Tu IMC es: {imc:.2f}")

if imc < 18.5:
    print("Diagnóstico: Bajo peso")
elif imc < 25:
    print("Diagnóstico: Peso normal")
elif imc < 30:
    print("Diagnóstico: Sobrepeso")
else:
    print("Diagnóstico: Obesidad")