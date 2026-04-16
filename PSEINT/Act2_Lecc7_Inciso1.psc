Algoritmo Act2_Lecc7_Inciso1
	Definir opc Como Real
	
	Escribir "******************"
	Escribir "BUZÓN DE VOZ"
	Escribir "1- Escuchar Mensajes"
	Escribir "2- Grabar Saludo"
	Escribir "3- Configuración"
	Escribir "4- Salir"
	Leer opc
	
	Segun opc Hacer
		1:
			Escribir "Usted ha solicitado ---> "
			Escribir "Escuchar sus mensajes nuevos"
		2:
			Escribir "Usted ha solicitado ---> "
			Escribir "Grabar un nuevo saludo de voz"
		3:
			Escribir "Usted ha solicitado ---> "
			Escribir "Entrar al menú de configuración"
		4:
			Escribir "Saliendo del sistema..."
		De Otro Modo:
			Escribir "Seleccione una opción válida!!"
	Fin Segun
FinAlgoritmo
