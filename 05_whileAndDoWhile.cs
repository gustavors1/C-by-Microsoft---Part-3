/* 
                            Instrucciones do-while y while

Las instrucciones do-while y while permiten recorrer en iteración un bloque 
de código con la intención de que la lógica que contiene afectará al momento 
de poder detener la iteración.
*/

/*

Escritura de una instrucción do-while para salir cuando se genere un número 
aleatorio determinado

A continuación se escribirá código que seguirá generando números aleatorios entre 1 y 10 
hasta que se genere el número 7. 
*/

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

/*
Un bloque de código que influye en los criterios de salida es una razón principal 
para seleccionar una instrucción do-while o while en lugar de una de las otras 
instrucciones de iteración. Tanto foreach como for dependen de factores externos 
al bloque de código para determinar el número de iteraciones de bloques de código.
*/

// Escritura de una instrucción while que solo itere mientras que un número aleatorio es mayor que un valor

Random random1= new Random();
int current2 = random1.Next(1, 11);

while (current2 >= 3)
{
    Console.WriteLine(current);
    current2 = random1.Next(1, 11);
}
Console.WriteLine($"Last number: {current2}");

/*
En este caso, se coloca la palabra clave while y la expresión booleana delante 
del bloque de código. Esto cambia el significado del código y actúa como una "puerta" 
para permitir el flujo de ejecución solamente si la expresión booleana se evalúa como true.
*/

/*
    Output: 
        9
        7
        5
        Last number: 1
*/

/*
En el código superior, se usa random para inicializar la variable int denominada current. La siguiente línea de código activa es nuestra instrucción while.

Nuestra instrucción while iterará en función de la expresión booleana (current >= 3). No sabemos qué valor se asignará a current, pero hay posibilidades que afectan a nuestro bucle while:

Si current se ha inicializado en un valor mayor o igual que 3, la expresión booleana devolverá true, y el flujo de ejecución entrará en el bloque de código. Dentro del bloque de código, lo primero que hacemos es escribir el valor de current en la consola. A continuación, todavía dentro del bloque de código, actualizamos el valor de current con un nuevo valor aleatorio. En este momento, el control vuelve a la parte superior de la instrucción while donde se evalúa la expresión booleana. Este proceso continúa hasta que la expresión booleana devuelve false y el flujo de ejecución se interrumpe del bloque de código.
Si current se inicializa (en la parte superior del código) en un valor menor que 3, la expresión booleana devolverá false, y el bloque de código nunca se ejecutará.
La línea de código final escribe el valor de current en la consola. Este código ejecuta si el bloque de código de iteración se ejecutó o no, y es nuestra oportunidad de escribir el valor final de current en la consola.
*/

// Uso de la instrucción continue para ir directamente a la expresión booleana

/* 
En algunos casos, el objetivo será cortocircuitar el resto del código dentro del bloque
y continuar a la iteración siguiente. Eso se puede hacer con la instrucción continue.
*/

Random random2= new Random();
int current3 = random2.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

/*
Hemos vuelto a cambiar a do-while. Un valor do-while garantiza que el bucle itera al menos una vez.

Lo primero que hacemos dentro del bloque de código es asignar un nuevo valor aleatorio 
a current. A continuación, comprobamos si current es mayor o igual que 8. Si esta 
expresión devuelve true, la palabra clave continue transferirá el control al final 
del bloque de código y while evaluará (current != 7). Así que el bucle continuará 
iterando siempre que el valor current no sea igual a 7.

La clave de este paso del ejercicio es la línea de código que contiene 
la palabra clave continue:

if (current >= 8) continue;

Dado que el código que escribe el valor de current en la consola se encuentra 
después de if (current >= 8) continue;, nuestro código garantiza que un valor 
de current que sea mayor o igual que 8 nunca se escribirá en la ventana de salida,
porque se lo salta con el continue
*/

// Desafío de la batalla del juego de rol

/*
Desafío de código: escribir código para implementar las reglas de juego
Estas son las reglas para el juego de batalla que necesita implementar en el proyecto de código:

Debes usar la instrucción do-while o la instrucción while como un bucle de juego externo.
El héroe y el monstruo comenzarán con 10 puntos de salud.
Todos los ataques serán un valor comprendido entre 1 y 10.
El héroe atacará primero.
Imprima la cantidad de salud que ha perdido el monstruo y su salud restante.
Si la salud del monstruo es mayor que 0, puede atacar al héroe.
Imprima la cantidad de salud que ha perdido el héroe y su salud restante.
Continúe con esta secuencia de ataque hasta que la salud del monstruo o del héroe sea cero o menos.
Imprima el ganador.
*/

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
/*
Examinar la diferencia entre las iteraciones de instrucción do y while

Como hemos visto, C# admite cuatro tipos de instrucciones de iteración: 
for, foreach, do-while y while. La documentación de referencia del lenguaje de Microsoft describe estas instrucciones de la siguiente manera:

La instrucción for ejecuta su cuerpo mientras una expresión booleana especificada se evalúa como true.
La instrucción foreach enumera los elementos de una colección y ejecuta su cuerpo para cada elemento de la colección.
La instrucción do-while ejecuta condicionalmente su cuerpo una o varias veces.
La instrucción while no ejecuta condicionalmente su cuerpo o lo hace varias veces.
*/

// Administrar la entrada de usuario durante este desafío
