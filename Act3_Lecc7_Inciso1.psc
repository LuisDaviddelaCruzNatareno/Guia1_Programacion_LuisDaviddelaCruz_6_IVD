Algoritmo Act3_Lecc7_Inciso1
	Definir dia, mes Como Real
	
	Escribir "Digite el número del día: "
	Leer dia
	Escribir "Digite el número del mes: "
	Leer mes
	
	Si (mes = 1) o (mes = 2) o (mes = 12) Entonces
		Escribir "Según la fecha ingresada ---> "
		Escribir "Usted está en INVIERNO"
	Sino
		Si (mes >= 3) y (mes <= 5) Entonces
			Escribir "Según la fecha ingresada ---> "
			Escribir "Usted está en PRIMAVERA"
		Sino
			Si (mes >= 6) y (mes <= 8) Entonces
				Escribir "Según la fecha ingresada ---> "
				Escribir "Usted está en VERANO"
			Sino
				Escribir "Según la fecha ingresada ---> "
				Escribir "Usted está en OTOÑO"
			FinSi
		FinSi
	FinSi
FinAlgoritmo
