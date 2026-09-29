using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

//entradas
double Base = 0;
double altura = 0;
double resultado = 0;

//procesos
Console.WriteLine("Ingrese una altura: "); //sin salto de linea
Base = double.Parse(Console.ReadLine());
Console.WriteLine("Ingresa la Base: ");
altura = double.Parse(Console.ReadLine());

resultado = (Base * altura) / 2;
//resultado
Console.WriteLine("El resultado es: " + resultado);


//entrada(tarea)
int edad = 0;
char letra = 'a';
string nombre = "";
float grados = 0f;
double pi = 0;
bool tengonovia = false;

//procesos
Console.WriteLine("Ingresa una edad: ");
edad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa una letra: ");
letra = char.Parse(Console.ReadLine());

Console.WriteLine("Ingresa un nombre: ");
nombre = Console.ReadLine();

Console.WriteLine("Ingresa grados: ");
grados = float.Parse(Console.ReadLine());

Console.WriteLine("Ingresa pi: ");
pi = double.Parse(Console.ReadLine());

Console.WriteLine("¿Tienes novia? (true/false): ");
tengonovia = bool.Parse(Console.ReadLine());

Console.WriteLine("Los resultados son: " + edad, + letra, + grados, + pi);
Console.WriteLine("Los resultados son: " + nombre);
Console.WriteLine("Los resultados son: " + tengonovia);

