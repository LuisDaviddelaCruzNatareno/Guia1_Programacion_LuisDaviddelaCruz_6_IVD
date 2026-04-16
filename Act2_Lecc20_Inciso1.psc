Algoritmo Act2_Lecc20_Inciso1
	Definir clave Como Caracter
	
	Escribir "SISTEMA DE SEGURIDAD"
	Escribir "Ingrese su contraseña: "
	Leer clave
	
	Si clave = "Password123" Entonces
		Escribir "Acceso concedido ---> "
		Escribir "¡BIENVENIDO!"
	Sino
		Escribir "Acceso denegado ---> "
		Escribir "INGRESO PROHIBIDO"
	FinSi
FinAlgoritmo
