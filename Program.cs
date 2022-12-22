// Ejercicio Sesion 2

/*
 Ejercicio 1
Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.
 */

Console.WriteLine("<-----Area del Ejercio 1------->");

Console.WriteLine("Escribe tu nombre aqui");
string nombre = Console.ReadLine();
Console.WriteLine("Introduce tu apellido");
string apellido = Console.ReadLine();
Console.WriteLine("Introduce tu edad");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sabes Programar 'Si' o 'No' ");
string sabes_programar = Console.ReadLine();


Console.WriteLine("<-------------------------------->");

Console.WriteLine(
    "\n Nombre: " + nombre +
    "\n Apellido: " + apellido +
    "\n edad: " + edad +
    "\n Sabes Programar: "+ sabes_programar);


Console.WriteLine("<----------------↓---------------->");

if (sabes_programar == "no")
{
    Console.WriteLine("\n Veo que no sabes Programar pero En Open BootCamp puedes apreder a programar desde cero");
}
else if (sabes_programar == "si")
{
    Console.WriteLine("\n Excelente puedes amplia su Stack en Open BootCamp");
}



Console.WriteLine("<-----Area del Ejercio 2------->");
/*
 * Ejercicio 2
 * Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
 */

//Coche
string marca = "Toyota";
int puertas = 4;
int ruedas = 4;
int vigencia = 25;
Console.WriteLine("<----------------↓---------------->");

Console.WriteLine(
    "\n Marca: " + marca +
    "\n Puertas: " + puertas +
    "\n Ruedas: "  + ruedas +
    "\n Vigencia " + vigencia);

Console.WriteLine("<----------------↓---------------->");
//Mesa
float peso = 150;
double largo = 3.5;
string material = "Madera";
string color = "Gris";

Console.WriteLine("<----------------↓---------------->");
Console.WriteLine(
    "\n Peso: "  + peso +
    "\n Largo: " + largo +
    "\n Material: "+ material +
    "\n Coloar "   + color);
Console.WriteLine("<-----Area del Ejercio 3------->");
/*
 Ejercicio 3
Operadores Determina los operadores para verificar las siguientes condiciones:
 */


Console.WriteLine("Ingrese el nombre");
string _nombre = Console.ReadLine();
Console.WriteLine("Introduce tu edad");
int _edad = Convert.ToInt32(Console.ReadLine());

if (_edad >= 18 && _nombre == "Pedro" || _nombre == "pedro")
{
    Console.Write("Eres Mayor de edad, puedes entrar {0} ", _nombre);
}
else
{
    Console.Write("Lo siento " + _nombre + " Eres Menor de edad y no te llamas Pedro ");
}

Console.ReadLine();