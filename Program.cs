// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//ENTRÉE
//string Celsius


//SORTIE
//string kelvin
//string fahrenheit

//DÉBUT
//ÉCRIRE "entrez Celsius"
//LIRE Celsius

//kelvin=Celsius+273,15

//fahrenheit=Celsius ­­* 1.8 + 32

//ECRIRE "Celsius"
//ECRIRE "kelvin"
//ECRIRE "fahrenheit
//FIN
const double CELSIUS_TO_KELVIN = 273.15;
const double CELSIUS_TO_FAHRENHEIT = 1.8 + 38;

string Celsius;
Double Kelvin,Fahrenheit;

Console.WriteLine("Veuillez rentrer la température en Celsius");

Celsius = Console.Readline();

Kelvin = (Convert.toInt32(Celsius) + CELSIUS_TO_KELVIN);
Fahrenheit = (Convert.toInt32(Celsius) * CELSIUS_TO_FAHRENHEIT);

Console.WriteLine($"Celsius:{Celsius} °C")
Console.WriteLine($"Kelvin:{kelvin} K")
Console.WriteLine($"Fahrenheit:{farenheit} °F")
