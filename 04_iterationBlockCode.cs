//  Iteración de un bloque de código mediante la instrucción for

/*
La instrucción for recorre en iteración un bloque de código un número específico de veces.
Este nivel de control hace que la instrucción for sea única entre las demás instrucciones 
de iteración. La instrucción foreach recorre en iteración un bloque de código una vez por 
cada elemento de una secuencia de datos, como, por ejemplo, una matriz o colección. 
La instrucción while recorre en iteración un bloque de código hasta que se cumple una 
condición.
*/

for (int i = 0; i < 10; i++) // Recorre el código 10 veces
{
    Console.WriteLine(i);
}
/*  
    Output: 
        0
        1
        2
        3
        4
        5
        6
        7
        8
        9
*/

/*
La instrucción for incluye las seis partes siguientes:

La palabra clave for.
Un conjunto de paréntesis que define las condiciones de la iteración for. Los paréntesis contienen tres partes distintas separadas por el operador de fin de instrucción, que es un punto y coma.
La primera parte define e inicializa la variable del iterador. En este ejemplo, int i = 0. Esta sección se conoce como inicializador.
La segunda parte define la condición de finalización. En este ejemplo, i < 10. En otras palabras, el entorno de ejecución seguirá iterando por el código del bloque de código que está debajo de la instrucción for mientras i sea menor que 10. Cuando i es igual a 10, el entorno de ejecución deja de ejecutar el bloque de código de la instrucción for. En la documentación se hace referencia a esta sección como condición.
La tercera parte define la acción que se realizará después de cada iteración. En este caso, después de cada iteración, i++ incrementará el valor de i en 1. En la documentación se hace referencia a esta sección como iterador.
Por último, el bloque de código. El bloque de código contiene el código que se ejecutará con cada iteración. Observe que se hace referencia al valor de i dentro del bloque de código. En la documentación se hace referencia a esta sección como cuerpo.
*/

// Cambio de las condiciones de iteración

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
/*
    Output:
        10
        9
        8
        7
        6
        5
        4
        3
        2
        1
        0
*/

// Experiencia con el patrón del iterador

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}
/*
    Output:
        0
        3
        6
        9
*/

// Uso de la palabra clave break para interrumpir la instrucción de iteración

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
/*
    Output:
        0
        1
        2
        3
        4
        5
        6
        7
*/

// Recorrido en bucle de todos los elementos de una matriz

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >=0; i--)
{
    Console.WriteLine(names[i]);
}
/*
En primer lugar, observe que hemos creado una instancia de una matriz de cadenas denominada names que contiene cuatro nombres.
A continuación, observe que usamos la propiedad Array.Length para obtener el número de elementos de la matriz y que usamos este valor para inicializar nuestra variable de iterador (int i = names.Length - 1). Restamos 1 del valor porque el número de índice de los elementos de matriz es de base cero (los números de índice de los cuatro elementos son 0-3).
Por último, observe que hemos elegido recorrer en iteración la matriz hacia atrás, algo que no podemos hacer con la instrucción foreach. Usamos el valor de la variable de iteración dentro del bloque de código para especificar el número de índice de los elementos de matriz (names[i]).En primer lugar, observe que hemos creado una instancia de una matriz de cadenas denominada names que contiene cuatro nombres.
A continuación, observe que usamos la propiedad Array.Length para obtener el número de elementos de la matriz y que usamos este valor para inicializar nuestra variable de iterador (int i = names.Length - 1). Restamos 1 del valor porque el número de índice de los elementos de matriz es de base cero (los números de índice de los cuatro elementos son 0-3).
Por último, observe que hemos elegido recorrer en iteración la matriz hacia atrás, algo que no podemos hacer con la instrucción foreach. Usamos el valor de la variable de iteración dentro del bloque de código para especificar el número de índice de los elementos de matriz (names[i]).
*/
/*
    Output:
        Michael
        David
        Eddie
        Alex
*/
// Podríamos haber iterado hacia delante por los elementos de matriz mediante la construcción de la instrucción for como se indica a continuación: for (int i = 0; i < names.Length; i++).

// Examen de la limitación de la instrucción foreach

string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}
/*
    Output:
        Cannot assign to name because it is a 'foreach iteration variable'
*/

// no se puede reasignar el valor de name porque forma parte de la implementación interna de la iteración foreach.

// Superación de la limitación de la instrucción foreach mediante la instrucción for

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);

// Con llaves

string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David") names[i] = "Sammy";
}


foreach (var name in names)
{
    Console.WriteLine(name);
}

/*
    Output:
        Alex
        Eddie
        Sammy
        Michael
*/
// Dado que la matriz no forma parte directamente de la implementación de la instrucción de iteración, se pueden cambiar los valores dentro de la matriz.

// Ejercicio: Realización de una actividad de desafío con instrucciones for e if

