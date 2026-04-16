Algoritmo Act3_Lecc7_Inciso2
	Definir a1, a2, a3 Como Real
	
	Escribir "Digite la medida de los tres ángulos:"
	Leer a1
	Leer a2
	Leer a3
	
	Si a1 = a2 y a2 = a3 Entonces
		Escribir "Resultado del análisis ---> "
		Escribir "Es un triángulo EQUILÁTERO"
	Sino
		Si a1 = a2 o a2 = a3 o a1 = a3 Entonces
			Escribir "Resultado del análisis ---> "
			Escribir "Es un triángulo ISÓSCELES"
		Sino
			Escribir "Resultado del análisis ---> "
			Escribir "Es un triángulo ESCALENO"
		FinSi
	FinSi
FinAlgoritmo
