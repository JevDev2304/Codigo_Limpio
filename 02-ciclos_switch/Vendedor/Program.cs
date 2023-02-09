/*Un vendedor desea calcular la comisión total
sobre la venta de varios artículos. Al vendedor
le corresponde el 10% de comisión sobre
artículos, cuyo precio es menor o igual a $1.000
y el 7% de comisión sobre aquellos artículos
cuyo precio sea mayor de $1.000. Elabore un
algoritmo para obtener la comisión total, si se
conoce que el vendedor hizo N ventas.
 */ 
int bandera = 1;
double dinero_vendedor = 0;
int contador_ventas_menores_1000 = 0;
int contador_ventas_mayores_1000 =0;
while(bandera == 1){
    Console.WriteLine("Hola Vendedor, ¿Deseas Ingresar una venta?\n para SI ingresa 1 y para NO ingresa 0. \nRespuesta: ");
    int respuesta = Convert.ToInt32(Console.ReadLine());
    if (respuesta == 1){
        Console.WriteLine("Ingresa el valor de la venta \n Respuesta: ");
        double valor_venta = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(valor_venta);
        if(valor_venta>1000){
            contador_ventas_mayores_1000++;
            dinero_vendedor = dinero_vendedor +(0.07*valor_venta);
            
        }
        else if (valor_venta <= 1000){
            contador_ventas_menores_1000++;
            dinero_vendedor = dinero_vendedor +(0.1*valor_venta);
        }
        
    }
    else if (respuesta == 0){
        break;
    }
  

    
    
}
Console.WriteLine("El dinero ganado por el vendedor es de {0}.,\nEl numero de ventas menores a 1000 COP son {1}.\nEl numero de ventas mayores a 1000 COP son {2}",dinero_vendedor,contador_ventas_menores_1000,contador_ventas_mayores_1000);
        Console.ReadKey();
        