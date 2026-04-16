Algoritmo Act2_Lecc21_Inciso1
	Definir opc Como Real
	
	Escribir "MENÚ DE CONTACTOS"
	Escribir "1- Ventas"
	Escribir "2- Recepción"
	Escribir "3- Dirección"
	Escribir "4- Compras"
	Leer opc
	
	Segun opc Hacer
		1:
			Escribir "Bienvenido al depto de VENTAS"
			Escribir "Responsable: Luis - luis@empresa.com"
		2:
			Escribir "Bienvenido al depto de RECEPCIÓN"
			Escribir "Responsable: Allan - allan@empresa.com"
		3:
			Escribir "Bienvenido al depto de DIRECCIÓN"
			Escribir "Responsable: Diego - diego@empresa.com"
		4:
			Escribir "Bienvenido al depto de COMPRAS"
			Escribir "Responsable: Anderson - anderson@empresa.com"
		De Otro Modo:
			Escribir "Depto. no encontrado"
	Fin Segun
FinAlgoritmo
