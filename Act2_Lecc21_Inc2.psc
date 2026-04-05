Algoritmo Act2_Lecc21_Inc2
	Escribir '==BUZON DE VOZ=='
	Definir num Como Entero
	Escribir 'Digite un número según las opciones'
	Escribir '1 VENTAS'
	Escribir '2 RECEPCIÓN'
	Escribir '3 DIRECCIÓN'
	Escribir '4 COMPRAS'
	Leer num
	Si num==1 Entonces
		Escribir 'Bienvenido al departamento de ventas'
		Escribir 'Responsable: Juan David Avila Ortiz'
		Escribir 'Correo: j.avila@gmail.com'
	SiNo
		Si num==2 Entonces
			Escribir 'Bienvenido al departamento de Recepción'
			Escribir 'Responsable: Jose Martin Miranda Lopez'
			Escribir 'Correo: j.miranda@gmail.com'
		SiNo
			Si num==3 Entonces
				Escribir 'Bienvenido al departamento de Dirección'
				Escribir 'Responsable: Diego Samuel Veliz Osorio'
				Escribir 'Correo: d.veliz@gmail.com'
			SiNo
				Si num==4 Entonces
					Escribir 'Bienvenido al departamento de Compras'
					Escribir 'Responsable: Andres Zamudio Esquivel'
					Escribir 'Correo: a.zamudio@gmail.com'
				SiNo
					Escribir 'NUMERO INVALIDO'
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo