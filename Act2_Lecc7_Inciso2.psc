Algoritmo Act2_Lecc7_Inciso2
	Definir nota Como Real
	
	Escribir "Ingrese la nota numérica (0 a 100): "
	Leer nota
	
	Si nota >= 90 Entonces
		Escribir "El rango obtenido es ---> "
		Escribir "EXCELENTE"
	Sino
		Si nota >= 80 Entonces
			Escribir "El rango obtenido es ---> "
			Escribir "MUY BIEN"
		Sino
			Si nota >= 70 Entonces
				Escribir "El rango obtenido es ---> "
				Escribir "BIEN"
			Sino
				Si nota >= 60 Entonces
					Escribir "El rango obtenido es ---> "
					Escribir "REGULAR"
				Sino
					Escribir "El rango obtenido es ---> "
					Escribir "DEFICIENTE"
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo
