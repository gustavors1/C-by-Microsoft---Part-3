
using System.Dynamic;
using System.Reflection.Metadata;

bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
/*
    Output: 
        Inside of the code block: 10
*/

// Intento de acceso a la variable fuera del bloque de código en el que está definida

Console.WriteLine($"Outside of code block: {value}");
/*
    Output: 
        error CS0103: The name 'value' does not exist in the current context
*/

// Mover la variable fuera

bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine($"Outside of code block: {value}");
/*
    Output: 
        error CS0165: Use of unassigned local variable 'value'
*/

/* 
Se trata de un problema de fácil solución, que proporciona otra perspectiva sobre cómo trabajar con bloques de código.

Si la línea de código value = 10; estaba fuera (encima) del bloque de código de 
la instrucción if, el compilador compilaría la aplicación y todo estaría bien. 
No obstante, como esa línea de código está dentro del bloque de código de la instrucción 
if, existe la posibilidad de que nunca se asigne un valor a la variable. 
En ese caso, la instrucción de código debajo del bloque de código que intenta 
mostrar value encontraría una variable no inicializada, que el compilador no permitirá.
*/

// Inicialización de la variable con un valor

bool flag = true;
int value = 0;

if(flag)
{
    value = 10;
    Console.WriteLine("Inside of code block " + value);
}
Console.WriteLine("Outside of code block: " + value);

/*
    Output:
    Inside of code block: 10
    Outside of code block: 10
*/

// Eliminación de bloques de código en instrucciones "if"

bool flag = true;
if (flag)
{
    Console.WriteLine(flag);
}
/*
El código anterior ejecuta un bloque de código cuando flag es true. 
Dado que este bloque de código contiene una sola línea de código, 
tiene la opción de quitar las llaves.
*/

bool flag = true;
if (flag)
    Console.WriteLine(flag);

// Examinar la legibilidad de las instrucciones "if" de formulario de una sola línea

bool flag = true;
if (flag) Console.WriteLine(flag);

// Este caso se dificulta la lectura del código  y más cuando hay secciones anidadas más grandes.

string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");

/* 
    Output:
        Found Steve
*/

// El código se ejecuta, pero estas líneas de código son densas y difíciles de leer

// Actualización de código 

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");

// Ejercicio: Realización de una actividad de desafío con el ámbito de las variables

int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
        bool found = true;
    }
}

if (found)
{
    Console.WriteLine("Set Contains 42");
}

Console.WriteLine($"Total: {total}");

/*
Complete las actualizaciones de código necesarias para que las instrucciones Console.WriteLine() existentes generen la salida deseada:

    Output:
        Set contains 42
        Total: 108

Es posible que sea necesario ajustar el ámbito de las variables.

Optimice el código para facilitar la lectura.

Dependiendo de la cantidad de espacios en blanco que incluya y otros factores, tendrá unas 17 líneas de código.
*/

// Tarea resuelta:

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = true; // Aquí debí cambiar a false 

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    	Console.WriteLine(found); // Aquí debí dejar la variable found y declarar el true.
}

if (found) 
    Console.WriteLine("Set contains 42");

Console.WriteLine("Total: " + total);

// Resolución del curso: 

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");