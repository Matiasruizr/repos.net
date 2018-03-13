using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos
{
    class Program
    {
        static void Main(string[] args)

        { 
            //Es una buena practica para un elemento vacio   
            string texto1 = string.Empty;
            //En el primer parametro definimos cuantos elementos tendra para poder formatear, luego los elementos
            string texto = string.Format("{0} {1}", "primera_parte", "segunda_parte");
            //Esta es una excelente manera de optimizar recursos

            Console.WriteLine("EL texto formateado ahora es: " + texto);

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Ingrese un numero");
            string texto2 = Console.ReadLine();
            int numero = 0;

            //Para corroborar si el valor ingresado es del tipo requerido utilizamos Tryparse
            //Tryparse( Elemento_a_cuestionar, out variable_en_donde_almacenar )
            if (int.TryParse(texto2,out numero)){ 
                //Ademas del valor, retorna un true o false, permitiendonos realizar la comprobación para el if
                Console.WriteLine("El numero ingresado es " + numero);
            }
            else{
                Console.WriteLine("No ingreso un numero");
            }

            Console.WriteLine("numero tiene almacenado " + numero);
            Console.ReadKey();// La consola se llama solo para realizar una funcion, con este  promp espera y lo evitamos
        }
    }
 }
