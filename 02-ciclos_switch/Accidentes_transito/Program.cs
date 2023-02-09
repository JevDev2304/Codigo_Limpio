using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Enunciado
/*
2.	Una oficina de seguros ha reunido datos concernientes a todos los accidentes de tránsito ocurridos 
 * en el área metropolitana de Medellín en el último año. Por cada conductor involucrado en un accidente 
 * se toman los siguientes datos: año de nacimiento, sexo (1: Femenino, 2: Masculino), 
 * registro del carro (1: Medellín, 2: Otras ciudades). Hacer un programa que muestre:
•	El porcentaje de conductores menores de 25 años.
•	Porcentaje de conductores del sexo femenino.
•	Porcentaje de conductores masculinos con edades entre 12 y 30 años.
•	Porcentaje de conductores cuyos carros están registrados fuera de Medellín.

*/


namespace Punto2_Taller_Repaso_FP
{
    class Program
    {


        static void Main(string[] args)
        {
            double porcentajeMenores25, porcentajeMujeres, porcentajeHombres12y30, porcentajeOtraCiudad;
            double añoDeNacimiento, sexo, registroDelCarro, menores25 = 0, mujeres = 0, hombres12y30 = 0, otraCiudad = 0, usuarios=0, s = 1;
            double añoActual = 2022, edad;
            //Menú de ingreso

            while (s == 1)
            {
                Console.Write("Ingrese el sexo: 1 para femenino, 2 para masculino:  ");
                sexo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la ciudad: 1 para Medellín, 2 para otra ciudad:  ");
                registroDelCarro = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el año de nacimiento:  ");
                añoDeNacimiento = int.Parse(Console.ReadLine());

                //Cuenta de Usuarios
                usuarios++;

                edad = añoActual - añoDeNacimiento;
                if (edad < 25)
                {
                    menores25++;
                }
                if (sexo == 1)
                {
                    mujeres++;
                }
                if (sexo == 2 && (edad >= 12 && edad <= 30))
                {
                    hombres12y30++;
                }
                if (registroDelCarro == 2)
                {
                    otraCiudad++;
                }
                //Reiniciar el ciclo de preguntas
                Console.WriteLine("¿Desea ingresar más datos? Ingrese: 1 para sí, 2 para no");
                s = int.Parse(Console.ReadLine());

            }
          
            //El porcentaje de conductores menores de 25 años.
            porcentajeMenores25 = (menores25*100 / usuarios);
            Console.WriteLine("El porcentaje de conductores menores de 25 años es de: {0:0.00}%", porcentajeMenores25);
            Console.ReadLine();

            //Porcentaje de conductores del sexo femenino.
            porcentajeMujeres = (mujeres *100/ usuarios);
            Console.WriteLine("El Porcentaje de conductores del sexo femenino es de: {0}%", porcentajeMujeres);
            Console.ReadLine();
            
            //Porcentaje de conductores masculinos con edades entre 12 y 30 años.
            porcentajeHombres12y30 = (hombres12y30 * 100 / usuarios) ;
            Console.WriteLine("El Porcentaje de conductores masculinos con edades entre 12 y 30 años es de: {0}%", porcentajeHombres12y30);
            Console.ReadLine();

            //Porcentaje de conductores cuyos carros están registrados fuera de Medellín.
            porcentajeOtraCiudad = (otraCiudad * 100/ usuarios) ;
            Console.WriteLine("El Porcentaje de conductores cuyos carros están registrados fuera de Medellín es de: {0}%", porcentajeOtraCiudad);
            Console.ReadLine();


        }
    }
}
