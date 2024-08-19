using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mostrando un mensaje por pantalla
            Console.WriteLine("1. Escribir un programa que declare variables para almacenar el nombre, la edad y \n la estatura de una persona. Asignar valores a las variables y luego mostrarlos en la consola.");
            Console.WriteLine("Ingrese su edad: ");
            int edad=int.Parse(Console.ReadLine());
            //mostrando un mensaje por pantalla
            Console.WriteLine("Ingrese su estatura: ");
            //habilitando la entrada de datos por teclado
            float estatura =float.Parse(Console.ReadLine());
            //mostrando un mensaje por pantalla
            Console.WriteLine("ingrese su nombre");
            //habilitando la entrada de datos por teclado
            string nombre =Console.ReadLine();
            Console.WriteLine($"Hola ¨{nombre} tienes {edad} años de edad y tu estatura es {estatura}");
            
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("2. Crear un programa que solicite al usuario dos números enteros y luego muestre el mayor y \n el menor de los dos números.");
            Console.WriteLine("Ingrese un numero entero");
            //habilitando la entrada de datos por teclado
            int numero =int.Parse(Console.ReadLine());
            //mostrando un mensaje por pantalla
            Console.WriteLine("ingrese un segundo numero entero");
            //habilitando la entrada de datos por teclado
            int numero2 =int.Parse(Console.ReadLine());

            if(numero > numero2)
            {
                //mostrando un mensaje por pantalla
                Console.WriteLine($"el numero {numero} es mayor");
                Console.WriteLine($"el numero {numero2} es menor");
            }
            else
            {
                //mostrando un mensaje por pantalla
                Console.WriteLine($"el numero {numero2} es menor");
                Console.WriteLine($"el numero {numero} es mayor");
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("3. Desarrollar un programa que convierta grados Celsius a Fahrenheit y viceversa. El programa\n debe solicitar al usuario la temperatura en Celsius o Fahrenheit y realizar la conversión correspondiente.");
            Console.WriteLine("ingrese la temperatura en Celsius ");
            //habilitando la entrada de datos por teclado
            float celcius =float.Parse(Console.ReadLine());
            //Grados Fahrenheit = (grados centígrados × 9/5) +32.
            float celciusAFahrenheit = ((celcius * 9) + 32) / 5;
            //mostrando un mensaje por pantalla
            Console.WriteLine($"Celcius a Fahrenheit es {celciusAFahrenheit}");
            Console.WriteLine("ingrese la temperatura en  Fahrenheit");
            float fahrenheit=float.Parse(Console.ReadLine());
            //(45 °F − 32) × 5/9 = 7,222 °C
            float fahrenheitACelcius = ((fahrenheit - 32) * 5) / 9;
            Console.WriteLine($"Fahrenheit a Celcius es {fahrenheitACelcius}");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("4. Escribir un programa que calcule el área y el perímetro de un cuadrado. El programa debe \nsolicitar al usuario la longitud de un lado del cuadrado.");
            Console.WriteLine("ingrese la longitud del cuadrado");
            //habilitando la entrada de datos por teclado
            float longitud =float.Parse(Console.ReadLine());
            double area = longitud * longitud;
            float perimetro = longitud * 2;
            Console.WriteLine($"el area es {area} y el perimetro es {perimetro}");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("5. Crear un programa que calcule el área y el volumen de una esfera. El programa debe \nsolicitar al usuario el radio de la esfera.");
            Console.WriteLine("ingrese el radio de la esfera");
            //habilitando la entrada de datos por teclado
            int radio =int.Parse(Console.ReadLine());
            // V = 4/3 π r³  A=4 π r
            double volumen =(4*(Math.PI)*Math.Pow(radio, 3))/3;
            double areaVolumen = 4 * (Math.PI) * Math.Pow(radio, 2);
            Console.WriteLine($"el area es {areaVolumen} y el volumen es {volumen}");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("6. Desarrollar un programa que realice las operaciones básicas aritméticas (suma, resta, \nmultiplicación y división) con dos números ingresados por el usuario.");
            Console.WriteLine("ingrese un numero entero");
            //habilitando la entrada de datos por teclado
            int num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un segundo numero entero");
            //habilitando la entrada de datos por teclado
            int num2 =int.Parse(Console.ReadLine());
            Console.WriteLine($"la suma es {num1 + num2}");
            Console.WriteLine($"la resta es {num1 - num2}");
            Console.WriteLine($"la multiplicacion es {num1 * num2}");
            Console.WriteLine($"la division es {num1 / num2}");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("7. Escribir un programa que compare dos números ingresados por el usuario y muestre si \nson iguales, mayores o menores.");
            Console.WriteLine("ingrese un numero entero");
            int num3=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un segundo numero entero");
            int num4=int.Parse(Console.ReadLine());
            //inicio de la sentencia if
            if(num3 == num4)
            {
                Console.WriteLine("son iguales");
            //inicio de la sentencia else if
            }else if(num3 > num4)
            {
                //mostrando mensajes por pantalla
                Console.WriteLine($"el numero {num3} es mayor");
            }
            else
            {
                //mostrando mensajes por pantalla
                Console.WriteLine($"el numero {num4} es menor");
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("8. Desarrollar un programa que calcule el módulo (residuo) de la división entre dos números\n ingresados por el usuario.");
            Console.WriteLine("ingrese el dividendo");
            //declarando variables de tipo entero
            int dividendo =int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el divisor");
            //declarando variables de tipo entero
            int divisor =int.Parse(Console.ReadLine());
            int resultado = dividendo % 2;
            Console.WriteLine($"el modulo es {resultado}");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("9. Crear un programa que declare una variable constante y una variable normal. Asignar \nvalores a ambas variables y mostrarlas en la consola.");
            Console.WriteLine("ingrese una materia");
            //habilitando la entrada de datos por teclado
            string materia =Console.ReadLine();
            Console.WriteLine("ingrese una constante");
            double pi =Math.PI;
            Console.WriteLine($"la variable ingresada es {materia} y la constante es {pi}");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("10. Escribir un programa que muestre un ejemplo de cómo se puede modificar el valor de\n una variable en C#.");
            //declarando variables de tipo entero
            int creditos = 4;
            creditos -= 2;
            Console.WriteLine($"el total de creditos es {creditos}");
            Console.WriteLine("11. Crear un programa que explique la importancia de usar nombres de variables descriptivos\n en C#.");
            string explicacion = "Porque me permite conocer de que se trata el codigo sin la necesidad de revisar a profundidad al tener variables y metodo descriptivos ";
            Console.WriteLine(explicacion);
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("12. Desarrollar un programa que muestre un ejemplo de cómo se puede declarar una variable\n con un tipo de dato específico en C#.");
            //declarando variables de tipo entero
            int ejemploNumerico = 4;
            Console.WriteLine($"ejemplo: variable de tipo entero {ejemploNumerico}");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("13. Crear un programa que muestre un ejemplo de cómo se puede inicializar una variable con\n un valor predeterminado en C#.");
            //declarando variables de tipo entero
            int valorPredeterminado = 56;
            Console.WriteLine($"el valor predeterminado es {valorPredeterminado}");
            Console.ReadKey();

            

        }
    }
}
