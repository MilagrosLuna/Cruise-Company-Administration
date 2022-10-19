<h1 align="center"><img src="https://media.discordapp.net/attachments/1011035308122456154/1032305449099329657/unknown.png"/></p> 



## Aplicación para administración de ventas de la empresa Friolito, compañía de cruceros.
Bueno, mi nombre es Milagros Luna, mi experiencia personal con este parcial es muy grata, tuve bastante de prueba y error, pero es lo que nos ayuda a aprender, me pareció una propuesta divertida, a pesar de tener complicaciones creo que pude lograr bastante de mi objetivo.

## Desarrollo


* Resumen:  A grandes rasgos la aplicación permite el ingreso de los usuarios (vendedores y un administrador), los cuales pueden acceder a la información de viajes, de pasajeros, poder generar un nuevo viaje, vender pasajes, ver datos históricos y para el administrador se le suma la posibilidad de añadir cruceros.

<h1 align="center"> Friolito ventas</h1>
<p align="center"><img src="https://media.discordapp.net/attachments/966847111742230578/1026502907576729630/unknown.png"/></p> 

## Tabla de contenidos:
---
- [Usuarios](#Usuarios)
- [Diagrama de clases](#Diagrama-de-clases)
- [Sobrecarga](#Sobrecarga)
- [Enumerados](#Enumerados)
- [Herencia Polimorfismo](#Heremcoa-Polimorfismo)
- [Validaciones](#Validaciones)
- [Propuesta de valor agregado para promoción](#Propuesta-de-valor-agregado-para-promoción)

## Usuarios
---
Usuarios Disponibles:


<p align="center"><img src="https://media.discordapp.net/attachments/1011035308122456154/1032304530769068062/unknown.png"/></p> 

<p align="center"><img src="https://media.discordapp.net/attachments/1011035308122456154/1032303959441936394/unknown.png"/></p> 

## Diagrama de clases
---
En el diagrama podemos ver el uso de distintas clases, tenemos clases “principales que ignoran detalles específicos” así como la clase pasajero que en su desarrollo no lleva la creación de un atributo edad, sino que contiene un atributo del tipo cliente quien a la vez deriva de persona y se encarga de la información básica (edad, genero, nombre, etc.).
Cada clase cuenta con su constructor base que inicializa sus datos en los valores default (cadenas vacías “ “, enteros = 0, etc.), y a la vez con su constructor parametrizado en el cual se validan los datos recibidos. También en la clase crucero hay un constructor estático que inicializa el dato capacidad en bodega, lo hice de esta manera porque en mi empresa se busca tener cruceros de similar capacidad.

<p align="center"><img src="https://media.discordapp.net/attachments/966847111742230578/1026503075885764650/unknown.png"/></p> 


## Sobrecarga
---
Utilizo la sobrecarga de operadores de == y también +, por ejemplo, para comparar que 2 viajes no sean iguales, comparo en base a la fecha de partida y destino, y la sobrecarga del operador + la utilizo por ejemplo en agregarle valijas a un pasajero, o agregar pasajeros a un viaje.  Al sobrecargar el ==, también hice la sobrecarga del Equals y GetHashCode. Para mostrar los datos de las entidades utilice la sobrecarga del toString pasándole un método (mostrar) que genera un string con la información del objeto.

## Enumerados
---
Utilice distintos enumerados para manejar la información como, por ejemplo, la nacionalidad de una persona, los destinos regionales, destinos extra regionales , genero de una persona , etc.

## Herencia Polimorfismo
---
También utilice herencia de clases y de forms,  la clase viaje es una clase abstracta por que no va a ser algo que se pueda instanciar solamente esta creada para manejar los datos básicos de un viaje y después tiene si es viaje regional o extra regional, los cuales contienen esos datos básicos y agregados de destino. En esta clase tengo aplicado polimorfismo al método mostrar, que después en cada tipo de viaje, utiliza el base y le agrega los datos faltantes.

## Validaciones
---
<p align="center"><img src="https://media.discordapp.net/attachments/1011035308122456154/1032305210409898065/unknown.png?width=630&height=610"/></p> 

## Propuesta de valor agregado para promoción
---
Usuario administrador capaz de agregar un crucero a la ”base de datos” de la compañía
<p align="center"><img src="https://media.discordapp.net/attachments/966847111742230578/1026503281134030878/unknown.png"/></p> 

