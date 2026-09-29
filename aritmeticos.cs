Console.WriteLine("Hello, World!");

//Operadores aritmeticos
/* + suma
 * - resta
 * * multiplicacion
 * Division
 * % Modulo
 */

double numero1 = 15;
double numero2 = 30;

Console.WriteLine(numero1 + numero2);
Console.WriteLine(numero1 - numero2);
Console.WriteLine(numero1 * numero2);
Console.WriteLine(numero1 / numero2);
Console.WriteLine(numero1 % numero2);


// Area de un circulo

// entradas
double radio = 0;
double pi = 3.141592;

Console.WriteLine("Ingresa el radio: ");
radio = double.Parse(Console.ReadLine());

double resultado = pi * (radio * radio);

Console.WriteLine("El resultado es: " + resultado);

// Area de un cuadrado
//entradas
double lado1 = 0;

Console.WriteLine("Ingresa el lado1: ");
lado1 = double.Parse(Console.ReadLine());


resultado = lado1 * lado1;
Console.WriteLine("El resultado: " + resultado);


//Area de un Rectangulo
//entradas
double Base = 0;
double altura = 0;

Console.WriteLine("Ingresa la base: ");
Base = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura: ");
altura = double.Parse(Console.ReadLine());

resultado = Base * altura;

Console.WriteLine("El resultado del area es de: " + resultado);

