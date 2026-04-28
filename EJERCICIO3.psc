Algoritmo CalculadoraIMC
    Escribir "Ingresa tu peso (kg): "
    Leer peso
    Escribir "Ingresa tu altura (m): "
    Leer altura
    
    imc <- peso / (altura * altura)
    
    Escribir "Tu IMC es: ", imc
    
    Si imc < 18.5 Entonces
        Escribir "Diagnóstico: Bajo peso"
    SiNo
        Si imc < 25 Entonces
            Escribir "Diagnóstico: Peso normal"
        SiNo
            Si imc < 30 Entonces
                Escribir "Diagnóstico: Sobrepeso"
            SiNo
                Escribir "Diagnóstico: Obesidad"
            FinSi
        FinSi
    FinSi
FinAlgoritmo