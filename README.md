# Parcial
* **Titulo:** "Celi airlines" - aplicacion de ventas y manejo de datos para una aerolinea.

* **Sobre mí:** Soy Rodrigo Fernandez Barbero, tengo 22 años, estudiante de la carrera Tecnicatura superior en programacion. Llevo preogramando desde 2019 de manera casual haciendo cursos pequeños online, pero ahora decidi enfocarme en la programacion mas de lleno. El trabajo en un principio lo disfrute mucho pero a medida que pasaba el tiempo me desmotivaba por la complejidad y el tiempo que me estaba llevando. Pero al final con el trabajo casi resuelto en su mayoria me dio un alivio y felicidad de lo que habia creado. 

* **Resumen:** La aplicacion permite visualizar vuelos de la aerolinea y sus respectivos pasajeros, dar de alta clientes, asignar esos clientes a los distintos vuelos para convertirlos en pasajeros. Permite ver estadisticas historicas de la empresa y como ultimo permite realizar un sorteo para ganarse un vuelo.

* **Diagrama de clases:**

![visual studio code logo](https://lh3.googleusercontent.com/_u_LgI8BB4IvKD3I00qGaxBklvc1R0OTtyOlqFeKuFKEnFeeAotd6JjpGLuZcWWeT8GANsv8eBaYzClqhZ9LllQU5WObvosQWM3qv1CT53UILPuFOTxiF6MeVZ-ifKKUnzZ2TaAklEw-Y02mvd4wqA9lQlmVKblvy2daKubgqmVtroTIUQwrm5qu0f6aJm5OIud4zmNAp3Mss59ZLnVwyc76DRZs3TAPQbfHXnnuO9_X5JdcP4ID0zewrjEqWfvBeyrDELiPu43DmeWziD-NMeooq_TJo0SrnoS1GXTH958SUkI6T67FC5VH74PawvjxxBk8XSC7BhXJRmz8eVppWEsWG3kUGo4I2AFawBdBv0SnP3aaJn2-DvRpIjGjYV1qkVosVfI4sUZzaUvz-F6JN9uSmlsxpQH42Q49bL-pgbmmcVvU5qojOuKgETNv--UCRgSrGqnasqhTn0BfT1XLdAac1gs2J-zy0UYU5s6qyXkuoFOFciHRzHbgMe0UrC6auNFXErCo1vBMU60AQ4JxTehmrUG63ARccicKs0mGDOjgdZbWmQ_wQxpw1q6TBM7o_ThF47vK-1vKEJLAMJyUouzjeHqvjiKKy-jLFCMzWPlD9X5OfougePCrw8vC0kEU90cy01qrX6JX43vwMC5f7YlcwMNFbS8xT7pLsPtE-fC5wiJAwx0-Q5Jza7FiGEPc5NFsgo5l_1SVcSUCHddBI_dSzC1BaOp4BrxHYEXUWViljzU1sQDRsWbyTxwuLwqd6-kJqo5YhZuvhoNvK4HR9KaCDQvhzj8JAlbCo3zEGsq-wCgtyd9TAB9vt8X0tlPqIFuPpyKgd7ms9HibIM7ie2MD6nAxosXUhpzEuawLXK6Lf634s7XxBmM80FixFGiN68z7w7iA0zpUiTY1YPINXcoas8G3GRZ-3_Wtug2AbwY-NkzUzyl_pQ65JgTJIBevDzMgxMGiEUyBF6Trrg=w1183-h367-no?authuser=0)



* **Justificacion técnica:** 
*

    Tema 1:
Sentencias foreach y for:
Para recorrer las listas de datos y poder tomar datos de ellas.

     Tema 2:
La aplicacion esta dividida en clases:
Se utiliza una clase estatica (AerolineaSistema) que va a hardcodear datos y va a ser llamada por otras clases. Decidi hacerla estatica porque es una clase que no la instancio en ningun momento y porque funciona de manera general con el resto de las clases.
Utilice metodos estaticos para metodos que solo realizan una tarea concreta y son llamdados en distintos lugares del codigo para evitar la repeticion y el DRY.

     Tema 3:
Programación orientada a objetos: Se utilizo un paradigma en el cual se tomen objetos de la vida real para resolver un problema. En este caso objetos existentes en una aerolinea
Abstraccion: Se tomo lo mas importante para el correcto uso de los objetos sin agregar informacion de mas que solo haria el programa mas largo y mas complicado de entender.
Clases: Se separo en clases. La clases que no son estaticas estan representadas por objetos lo que hace que el codigo sea mas facil de comprender y mas sencillo de programar. Cada clase tiene un nombre propio y se encarna de cosas especificas.
Objetos: Se instancian en memoria para su uso. Al momento de crear nuevas instancias del mismo se llama a su constructor para su correcto funcionamiento.

    Tema4: 

Sobrecarga: Se utilizaron sobrecargas para evitar repetir codigo y añadir una nueva funcionalidad.
Sobrecarga de operadores: Se utilizo sobrecarga de constructores para situaciones en las que un objeto no necesite de todos los datos para poder instanciarse en memoria. Clase Avion tiene una sobrecarga ya que al momento de cargar un avion nuevo no necesitan tener pasajeros.
Sobrecarga de metodos: en la clase Cliente, los metodos devuelven dos datos distintos (un bool, un string)

    Tema 5:
Windows Forms: Se utilizaron distintos windows forms para resolver todo lo requerido por el usuario y el manejo correcto y ordenado de los objetos.

    Tema 6:
Colecciones: Se utilizaron listas de objetos para almacenar y gestionar los datos de los mismos y asi poder mostrarselos al usuario.
Se utilizo un diccionario, en la funcionalidad nueva, para mostrar los clientes previos ganadores del sorteo.

    Tema 7.
Encapsulamiento: Cada clase posee sus atributos privados para que los usuario no puedan pisarlos con otra informacion, si se precisa usar su informacion implemente propiedades para poder leer y asignar el valor de esos atributos y asi utilizarlos como convenga. Cada miembro de las clases tiene el nivel de proteccion pertinente para la situacion que son utilizados (las clases abstract poseen sus miembros protected).
Enumerados: Clases Origen, Destino, Pasajero utilizan los enumerados para poder utilizar cierto datos requeridos, asignandoles un valor numerico para asi poder acceder a ellos. 


    Tema 8:
Herencia: Utilice la herencia con las clases Persona(clase padre), Vendedor(clase hija), Cliente(clase hija), Pasajero(clase hija), ya que me parecio la forma correcta de mantener un orden y ahorrar codigo. Ademas debido a que estas clases comparten datos propios basico de cada persona el uso de Herencia lo hace mas facil de entender.
    Tema 9:
Clases abstractas - polimorfismo: Se utilizo la clase persona como englobadora de sus clases hijas debido a que tiene los datos basicos de las personas y no tendria sentido instanciarla como un objeto ya que no tiene ninguna funcionalidad por ende la clase es abstacta y sus miembros protected para que solo puedan ser utilizados por sus clases hijas.
Polimorfismo: En la clase Persona se utiliza metodo para enviar un mensaje el cual lo sobreescribe la clase Cliente y modifica su funcionalidad.
Ademas se sobreescribe Equals para comparar objetos en listas, GetHashCode (para comparar el codigo recibido y que no sea el mismo) y el ToString para imprimir los datos del objeto

Extra: Uso de Biblioteca externa Regex para validar numeros y letras.

****************
****************


 **Propuesta de valor agregado:** Realice un apartado que por medio de un usuario administrador, permita realizar un sorteo de entre la lista de clientes y asi añadirlo a un vuelo ya generado.

**Uso:** Se debe ingresar como usuario administrador con los siguientes datos: **Usuario:** "admin.supremo"
**Clave:** "abc123".
Esto permitira la existencia de un nuevo boton en ROJO, que permite realizar sorteos. Tomando el dato de la persona de la lista de clientes registrada y permitiendo asignar a la misma a un vuelo (cliqueando en el datagrid de los vuelos el elegido) como parte del premio y muestra una lista de clientes ya ganadores del sorteo.
