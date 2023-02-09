
            Console.WriteLine("Por favor Ingrese su nombre");
            string nombre = "";
            nombre = Console.ReadLine();
            Console.WriteLine(nombre + " Bienvenido a C# ");
            int numero1, numero2;
            Console.WriteLine("Por favor ingrese un número ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor ingrese otro número");
            numero2 = Convert.ToInt32(Console.ReadLine());
            int resultado = numero2+ numero1;
            Console.WriteLine("los numero a sumar son " + numero1 + " y " + numero2 + ". El resultado es " + resultado);
            Console.WriteLine("Ahora vamos a comparar numeros :D");
            int numero3,numero4;
            Console.WriteLine("Por favor Ingresa el primer número");
            numero3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor Ingresa el segundo número");
            numero4 = Convert.ToInt32(Console.ReadLine());
            if (numero3 > numero4)
			{
                Console.WriteLine(numero3 + " es mayor que " + numero4);
			}
            else if (numero3 < numero4)
			{
                Console.WriteLine(numero4 + " es mayor que " + numero3);
			}
			else
			{
                Console.WriteLine("Los numeros son iguales");
			}
            int lado1,lado2,lado3;
            Console.WriteLine("Ingrese el primer lado");
            lado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo lado");
            lado2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer lado");
            lado3= Convert.ToInt32(Console.ReadLine());
            if ((lado1 > lado2 +lado3) || (lado2>lado1+lado3) || (lado3> lado1 + lado2))
			{
                Console.WriteLine("No se puede formar un Triangulo D:, ya que no cumple la Desigualdad triangular");
			}
			else
			{
                Console.WriteLine("Si se puede formar un Triangulo :D, Si cumple la desigualdad triangular");
			}
