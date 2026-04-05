Algoritmo Act3_Lecc20_Inc1
	Escribir '==DIAS DE LA SEMANA=='
	Definir dia Como Entero
	Escribir 'Dime el número del día de la semana'
	Leer dia
	Si dia>=1 Y dia<=5 Entonces
		Escribir 'ENTRE SEMANA'
	SiNo
		Si dia==6 O dia==7 Entonces
			Escribir 'FIN DE SEMANA'
		SiNo
			Escribir 'NUMERO INVALIDO'
		FinSi
	FinSi
FinAlgoritmo
