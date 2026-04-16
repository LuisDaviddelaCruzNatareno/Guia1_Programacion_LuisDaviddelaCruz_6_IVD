Algoritmo Act1_Lecc7_inciso1
	Definir n1, n2, n3, n4, n5, promedio Como Real
    Escribir "Ingrese las 5 notas:"
    Leer n1, n2, n3, n4, n5
    promedio <- (n1 + n2 + n3 + n4 + n5) / 5
    Si promedio >= 70 Entonces
        Escribir "Aprobado con: ", promedio
    Sino
        Escribir "Reprobado con: ", promedio
    FinSi
FinAlgoritmo
