Algoritmo Act1_Lecc7_Inc1
	Escribir '==PROMEDIO DE CALIFICACIONES=='
	Definir materia Como Cadena
	Definir n1, n2, n3, n4, n5 Como Entero
	Definir promedio Como Real
	Escribir 'Escriba la materia'
	Leer materia
	Escribir 'Dame 5 notas: '
	Leer n1
	Leer n2
	Leer n3
	Leer n4
	Leer n5
	promedio <- (n1+n2+n3+n4+n5)/5
	Si promedio>=70 Entonces
		Escribir 'Estudiante Aprobado con ', promedio
	SiNo
		Escribir 'Estudiante Reprobado con ', promedio
	FinSi
FinAlgoritmo
