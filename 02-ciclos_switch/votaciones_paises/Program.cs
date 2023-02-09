using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCiclos
{

    /*
    En el proceso para elegir la sede del Mundial 2030, se presentaron 4 países, usted ha sido elegido para diseñar el programa con el cual se 
    sacarán los datos estadísticos de esta jornada. Los países que se presentaron son:
•	Inglaterra
•	Argentina
•	Italia
•	México

Por cada representante de los países que pueden votar, se registra el nombre país por el cual votó. Los resultados estadísticos que debe arrojar 
el programa son:
a.	Total de votos de cada uno de los 4 países.
b.	Nombre del país ganador
c.	Mostrar el país con la menor cantidad de votos.
         */
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, votosInglatera = 0, votosArgentina = 0, votosItalia = 0, votosMexico = 0;
            do
            {
                Console.Write("Ingrese el número del país por el que desea votar \n 1 - Inglaterra \n 2 - Argentina \n 3 - Italia \n 4 - México \n 5 - Salir \n Opción: ");
                opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion) {                 
                    case 1:
                        votosInglatera++;
                        break;
                    case 2:
                        votosArgentina++;
                        break;
                    case 3:
                        votosItalia++;
                        break;
                    case 4:
                        votosMexico++;
                        break;
                    case 5:
                        Console.WriteLine("A continuación se presentarán los resultados estadisticos");
                        break;
                    default:
                        Console.WriteLine("No existe la opción seleccionada");
                        Console.ReadKey();
                        break;

                }
            } while (opcion != 5);

            Console.WriteLine("El total de votos de Inglaterra es {0}", votosInglatera);
            Console.WriteLine("El total de votos de Argentina es " + votosArgentina);
            Console.WriteLine("El total de votos de Italia es {0} y el total de votos de México es {1}", votosItalia, votosMexico);
            Console.WriteLine("El total de votos de México es {0}", votosMexico);
            if ((votosInglatera > votosArgentina) && (votosInglatera > votosItalia) && (votosInglatera > votosMexico))
            {
                Console.WriteLine("El país ganador es Inglaterra");
            }
            else if ((votosArgentina > votosItalia) && (votosArgentina > votosMexico))
            {
                Console.WriteLine("El país ganador es Argentina");
            }
            else if (votosItalia > votosMexico)
            {
                Console.WriteLine("El país ganador es Italia");
            }
            else {
                Console.WriteLine("El país ganador es México");
            }
                
            Console.ReadKey();


        }
    }
}
