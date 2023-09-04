// Uso del operador de igualdad

/*
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
*/
// Trim() para quitar espacios y ToLower() para poner todo en minìsculas.

/*
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");
*/

/*
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
*/

/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
*/

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

/*
El término "negación lógica" se refiere al operador !. Algunas personas llaman a este 
operador el "operador not". Cuando coloca el operador ! antes de una expresión 
condicional (o cualquier código que se evalúe como true o false), obliga al código 
a asegurarse de que la expresión sea falsa.
*/

// Operador Condicional Formato

// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

/*
Imagine que necesita determinar rápidamente si la compra de un cliente es válida 
para un descuento promocional. Los detalles de la promoción indican que cuando 
un valor de compra es mayor que 1000 USD, la compra es apta para un descuento 
de 100 USD. Si el importe de la compra es de 1000 USD o menos, la compra es apta 
para un descuento de 50 USD.
*/

int saleAmount = 1001;
int discount = saleAmount > 100 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");


// Podemos eliminar la variable temporal discount para compactar aún más este código.

int saleAmount2 = 1001;
Console.WriteLine($"Discount: {(saleAmount2 > 1000 ? 100: 50)}"); // Código más difícil de leer.

// implementará un operador condicional para simular un "cara o cruz". La lógica de decisión resultante mostrará heads o tails.

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

// Desafío de lógica de decisión

/*
Estas son las reglas de negocios que la solución debe satisfacer:

Si el usuario es administrador con un nivel superior a 55, se genera el mensaje:

Output
Welcome, Super Admin user.

Si el usuario es administrador con un nivel inferior o igual a 55, se genera el mensaje:

Output
Welcome, Admin user.

Si el usuario es director con un nivel superior a 20, se genera el mensaje:

Output
Contact an Admin for access.

Si el usuario es director con un nivel inferior a 20, se genera el mensaje:

Output
You do not have sufficient privileges.

Si el usuario no es ni administrador ni director, se genera el mensaje:

Output
You do not have sufficient privileges.
*/

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user");
    }
    else
    {
        Console.WriteLine("Welcome, Admin User");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact and Admin for access.");
    }
    else 
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else 
{
    Console.WriteLine("You do not have sufficient privileges.");
}




