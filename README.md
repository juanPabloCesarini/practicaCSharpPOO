# practicaCSharpPOO
Continuación del curso de EducacionIT becado por el INET
## TP1 de POO

Temas: Clases, Constructores, Métodos, Creación de Objetos, Instanciación.

Ejercicio1:

1)	Generar una Clase que se llame Estudiante y que tenga los siguientes atributos (Nombre, Apellido, Legajo)
2)	Generar un Constructor por Default que inicialice los atributos.
3)	Crear un segundo Constructor que sea por Parámetros que inicialice los siguientes atributos.
-	Nombre: juan, Apellido: Gonzalez, Legajo: 1599.
4)	Crear un Método llamado Imprimir que muestre un mensaje que diga:
“Su nombre es “ + atributo + “ y su apellido es: “ + atributo 2 + “ y su Legajo es “ + atributo3 
5)	Crear dos objetos llamados Est1 y Est2.
6)	A los dos objetos instanciarles el método Imprimir.   

Ejercicio2:

1)	Generar una Clase que se llame Cubo y que tenga 3 atributos (lado, área y volumen)
2)	Crear 2 Métodos llamados CalcularVolumen y CalcularArea.
3)	Crear un objeto llamado micubo.
4)	Cargar los datos en el void e imprimir los resultados de los métodos creados.   

Ejercicio3:

1)	Generar una Clase que se llame Cuadrado.
2)	Crear los atributos necesarios.
3)	Crear 3 Métodos llamados Inicializar (se encargará de cargar los datos), CalcularPerimetro (calculará el perímetro de un cuadrado y lo informará) y Calcular Superficie (calculará la superficie de un cuadrado y lo informará)
4)	Crear un objeto llamado micuadrado.
5)	Instanciar los métodos creados.   

## TP2 de POO

Temas: Clases, Constructores, Métodos, Creación de Objetos, Instanciación.

Ejercicio1:

1)	Generar una Clase que se llame ClaseTrabajador y que tenga los siguientes atributos (Nombre, Apellido, Sector, Sueldo1, Sueldo2)
2)	Generar un Constructor por Default que inicialice los atributos.
3)	Crear un segundo Constructor que sea por Parámetros que inicialice los siguientes atributos.
-	Nombre: juan, Apellido: Gonzalez; Sector: A; Sueldo1: 4500; Sueldo2: 5000.
4)	Crear un Método llamado TotalSueldo que sume los sueldos y los muestre.
5)	Crear un Método llamado TipoSector, que si ingreso A me informe Administrativo si es P, me informe Producción y si es S, es Secretaria.
6)	Crear un Método llamado Imprimir que muestre un mensaje que diga:
“Su nombre es “ + atributo + “ y su apellido es: “ + atributo 2 + “ y su edad es “ + atributo3 + “ y trabaja en el sector “ + atributo4 + “ y el sueldo Total es: + atributo5.
7)	Crear dos objetos llamados Trab1 y Trab2.
8)	A los dos objetos instanciarles el método Imprimir.   

Ejercicio2:

1)	Generar una Clase que se llame ClaseAlumno y que tenga 5 atributos (Nombre, Apellido, Legajo, Edad  y Cuota)
2)	Generar un Constructor por Default que inicialice con los siguientes datos:
            edad = 19;
            nombre = "Javier";
            apellido = "Perez";
            legajo = 2109;
         cuota = 2896;

3)	Crear un segundo Constructor que sea por Parámetros que inicialize con los siguientes datos:
               Edad: 33, nombre: "Pedro", apellido:"lopez", legajo: 4589, Cuota: 12650

4)	Crear un Método llamado MostrarEdad que informe en una variable string si es mayor de 18 años mediante el siguiente mensaje “Mayor de Edad” sino “Menor de Edad”.

5)	Crear un Método llamado MostrarCuota que analize e informe las siguientes condiciones:

Cuota mayor a cero y menor a 5000                   – informar : Cuota Accesible
Cuota mayor o igual a 5000 y menor a 10000    – informar : Cuota Cara
Sino                                                                        -- informar : Cuota Muy Cara


6)	Crear un Método llamado Imprimir que muestre un mensaje que diga:

El alumno se llama + atributoNombre + y su apellido es + atributoapellido + y su Edad es: + atributoedad +  Por lo tanto es: + mostarEdad +  y la cuota que paga es: + mostrarCuota

7)	Crear dos objetos llamados Alu1 y Alu2.
8)	A los dos objetos instanciarles el método Imprimir.   

## TP3 de POO

Temas: Clases, Métodos, Propiedades de solo Lectura.

Ejercicio1:

1)	Generar una Clase que se llame Estudiante que tenga 4 atributos (Nombre, Apellido, DNI, Edad)
2)	Generar un Método llamado CargarDatos que ingrese por consola los 4 datos.
3)	Crear un segundo Método llamado ImprimirDatos que informe los 4 atributos mediante un Console.WriteLine.
4)	Crear un objeto llamado Est1 e instanciarle los dos objetos creados.   

Ejercicio2:

1)	Al ejercicio anterior crearle 4 Propiedades y realizarles lo siguiente:

-	En Apellido hacer que se ingrese en minúsculas y que desde la propiedad se transforme a mayúsculas.
-	En Nombre hacer que se ingrese en mayúsculas y desde la propiedad se transforme a minúsculas.
-	En Edad, se validará para que se ingresen edades mayores a cero y menores a 100. Para ello, informar con un mensaje que si la edad ingresada esta entre 0 y 100 diga “Edad Correcta” sino “El valor de la edad tiene que ser entre 0 y 100 – Ingrésela de nuevo”
-	En DNI, hacer la lectura y escritura mediante el GET/SET.

Ejercicio3:

Generar una Clase que se llame Ventas que tenga 3 propiedades de lectura y escritura (Producto, Precio Unitario y Cantidad)
1)	Generar un Método llamado CargarDatos que ingrese por consola los 3 datos.
2)	Crear tres Propiedades de solo Lectura (Subtotal, IVA, Total Gral), que deberán realizar los cálculos.
3)	Generar un Método Imprimir que muestre el siguiente detalle:


          ----- Listado de Productos -----
Producto:
Precio Unitario:
Cantidad
Subtotal:
IVA 21%
Total General: 

4)	Crear un objeto llamado Ventas1 e instanciarle los objetos creados.   
Ejercicio4:

1)	Generar una Clase que se llame Trabajador que tenga 4 atributos (Legajo, Apellido, Nombre, Mes de Ingreso)
2)	Cargar los datos mediante la 2da forma.
3)	Crear un Método llamado ValidarMes, que informe si el valor ingresado del mes es válido. En caso contrario informar mes ingresado incorrecto y volver a pedir ingresar el mes que lo valide si es correcto o no.
4)	Crear un segundo Método llamado Validar, que informara en letras el nombre del mes, siempre y cuando, el mes sea correcto.
5)	Crear un tercer Método llamado Imprimir, que 
6)	Crear un objeto llamado Trab1 e instanciarle los dos objetos creados.   

Ejercicio5:

Crea una clase Cuenta (bancaria) con atributos para el número de cuenta, el DNI del cliente y el saldo actual.
Generar un Constructor por defecto y constructor con DNI y saldo. 
Define en la clase los siguientes métodos:   

	actualizarSaldo(): actualizará el saldo de la cuenta aplicándole el interés diario (interés anual dividido entre 365 aplicado al saldo actual). 
	ingresar(double): permitirá ingresar una cantidad en la cuenta. 
	retirar(double): permitirá sacar una cantidad de la cuenta (si hay saldo). 
	Método que permita mostrar todos los datos de la cuenta.

## Practica de Herencia

## Tema: Crear clases con Herencia

Ejercicio 1: Resolver  los siguientes puntos.

1)	Generar una clase llamada Operación que tendrá 3 propiedades protegidas (nro1, nro2, resultado)
2)	Establecer las propiedades de escritura y lectura.
3)	Generar 2 clases llamadas SUMA y Resta, que heredaran los atributos de la superclase. 
4)	Además crear para ambas clases  un método llamado operar que informara el resultado de la operación.
5)	En el programa principal, llamar a Suma y Resta. Ingresarles los valores desde el void y llamar al método Operar.
6)	Generar dos métodos llamados Imprimir que informen el resultado de la suma y la resta. 
7)	Crear una tercera clase llamada Producto, que heredara los atributos de la superclase e informar el resultado usando un método Imprimir.

Ejercicio 2: Realizar los siguientes puntos.

Una compañía de editorial produce tanto libros impresos como audio-libros. 
Diseñe una clase denominada Publicación que almacenara el título, autor y precio.
A partir de esta se derivarán 2 clases libro y CD. 
A la clase libro se le agregara el número de páginas. 
A la otra clase CD, se le deberá agregar el tiempo de reproducción.

Generar las propiedades de lectura y escritura.
Generar un método que informe los datos de cada clase.

Ejercicio 3:   Resolver el siguiente problema.

1)	Crear una clase llamada Persona que tendrá tres campos: Nombre (texto), Apellido(texto) y Edad (entero)
2)	Generar un Constructor de persona que recibirá los tres argumentos.
3)	Crear una Propiedad de Lectura llamada APENOM, que informara la concatenación del Nombre guion Apellido. ¿Qué función usaría?
4)	Generar una segunda Propiedad de Lectura llamada LargoApellido, que informara el largo del apellido. ¿Qué función usaría?
5)	Generar una tercera Propiedad de Lectura llamada Info, que informara “apellido Largo” si tiene 10 o más letras y sino “apellido Corto”.
6)	Generar un método Imprimir que informara Nombre, apellido en mayúsculas, Nombre y apellido concatenado, largo del apellido y el tipo de Apellido. 
7)	Crear una segunda clase llamada Estudiante, que tendrá un campo llamado Matricula y año cursado.
8)	Inicializar cada estudiante en base al constructor de la clase Persona.
9)	Usando el método Imprimir, informar los datos de la clase persona más los dos campos de estudiante.
10)	Crear dos objetos (Per1 y Est1) e informar los resultados,
