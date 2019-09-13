# Universidad Católica del Uruguay

## Facultad de Ingeniería y Tecnologías

### Programación II

## Ejercicio Herencia

### Objetivo
El objetivo de este ejercicio es el de aplicar los conceptos adquiridos de Herencia y Agregación, así como también
sobrecarga y override de métodos y clases abstractas.

### Introducción
Últimamente, se ha vuelto muy difícil encontrar lugar para estacionar en la cercanía de la universidad. Es por ello, que la facultad de Ingeniería, ha tomado la iniciativa de crear un programa de "Ridesharing" gratuito entre profesores y alumnos de la universidad. 
Este nuevo sistema, denominado UCURide funcionará de la siguiente forma: 
Tanto alumnos, como profesores podrán postularse como voluntarios, ofreciendo sus vehículos como medio compartido. A estos se los denomnará **Conductores**. Todos los demas usuarios seran los **Pasajeros**.
 * Los Conductores tendran ciertos atributos mínimos, como ser Nombre, Apellido, Cédula, un Vehículo, una Calificación como conductor y una breve bio.
 * Los Pasajeros tendran sus propios atributos, como ser Cédula, Nombre, Apellido, calificación como Pasajero
(A los efectos de este sistema, no es necesario diferenciar entre Profesores y Alumnos).

A su vez, los conductores podran ser identificados de dos formas: 
* **Comunes:** Solamente levaran a un pasajero por vez
* **Pool:** Estan dispuestos a realizar un viaje con multiples pasajeros

Con el fin de promocionar este nuevo servicio, la Facultad ha creado una nueva cuenta de twitter, en la cual desea publicar cada nuevo registro de conductores y pasajeros. Cada vez que un nuevo voluntario se registra como conductor, se publicará una foto del conductor con su bio y un mensaje de bienvendia. Cada vez que un nuevo pasajero se registra para utilizar la app se debera publicar tambien su foto de perfil con su nombre. 

### Desafío 1
Deberás identificar todas las clases del problema y como estas se relacionan entre si. Para representar esto, debes utilizar un diagrama UML muy básico, el cual podrá ser en papel o utilizando una herramienta como draw.io

### Desafío 2
Deberas programar todas estas clases junto con un ejemplo de ejecución en el Program. 
En cuanto al funcionamiento del sistema, solamente es necesario mantener una lista de Conductores y Pasajeros y realizar la publicación correspondiente cuando se agrega un nuevo pasajero o conductor. Para ello, podrás hacer uso de la API de twitter provista en el siguiente repo: https://github.com/ucudal/PII_TwitterApi

### Desafío 3 (Desafío Bonus!)
Si bien la universidad espera que los usuarios, al ser adultos, no publiquen fotos inadecuadas en twitter, todos pueden cometer errores y por lo tanto se desea aplicar un filtro a las potenciales fotos a publicar:
 * Todas las fotos de perfil de los pasajeros deberan contener una cara.
 * Todas las fotos de perfil de los conductores deberan contener una cara y además estar sonriendo.

Para ello, podrás hacer uso de la API de twitter provista en el siguiente repo: https://github.com/ucudal/PII_CognitiveAPI