Algoritmo Calculadora
    Leer num1, num2
    Escribir "1=Suma, 2=Resta, 3=Multiplicación, 4=División"
    Leer opcion
    
    Según opcion Hacer
1: Escribir "Resultado: ", num1 + num2
2: Escribir "Resultado: ", num1 - num2
3: Escribir "Resultado: ", num1 * num2
4: 
	Si num2 == 0 Entonces
		Escribir "Error: no se puede dividir entre 0"
	SiNo
		Escribir "Resultado: ", num1 / num2
	FinSi
De Otro Modo:
	Escribir "Opción no válida"
FinSegun
FinAlgoritmo