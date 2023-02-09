/*En un curso se practican 4
evaluaciones con los siguientes
porcentajes: 25%, 20%, 25% y 30%,
respectivamente. Por cada estudiante
se informa código y las cuatro notas.
Hacer un algoritmo que calcule la
nota definitiva de cada estudiante, el
promedio de notas definitivas del
curso y el porcentaje de perdedores.*/
int bandera = 1;


List<double> notas = new List<double>() {};
List<string> codigos = new List<string>(){};
double EstudiantesGanadores = 0;
double EstudiantesPerdedores = 0;
double NumeroTotalEstudiantes =0;

do{
Console.WriteLine("Ingresa el codigo del estudiante");
string codigo = Console.ReadLine();
Console.WriteLine(" Ingresa la nota del 25%");
double Nota_25 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Ingresa la nota del 20%");
double Nota_20 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Ingresa la segunda nota del 25%");
double SegunddaNota_25 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Ingresa La nota del 30%");
double Nota_30 = Convert.ToDouble(Console.ReadLine());
List<double> notas_estudiante = new List<double>() {};
Console.WriteLine(String.Join(", ", notas_estudiante));   
Console.WriteLine("Ingrese 0 para terminar el ciclo");
double promedio = ((Nota_20 * 0.20) +(Nota_25 *0.25)+(SegunddaNota_25 * 0.25)+ (Nota_30 * 0.3));
bandera = Convert.ToInt32(Console.ReadLine());
notas.Add(promedio);
codigos.Add(codigo);

}
while(bandera == 1);

foreach(double nota in notas){
    
    NumeroTotalEstudiantes= NumeroTotalEstudiantes+1;
    if (nota>=3){
        EstudiantesGanadores= EstudiantesGanadores+1;
    }
    else{
        EstudiantesPerdedores = EstudiantesPerdedores+1;
    }
    }

Console.WriteLine("INFORME DE ESTUDIANTES:");
Console.WriteLine("Estudiantes Ganadores {0}",EstudiantesGanadores);
Console.WriteLine("Estudiantes perdedores {0}",EstudiantesPerdedores);
Console.WriteLine("Estudiantes Total {0}\n",NumeroTotalEstudiantes);
double porcentajeGanados = (EstudiantesGanadores/NumeroTotalEstudiantes)*100;
double porcentajePerdidos = (EstudiantesPerdedores/NumeroTotalEstudiantes)*100;
Console.WriteLine("INFORME DE PORCENTAJES:");
Console.WriteLine("El porcentaje de estudiantes que ganaron la asignatura es {0} %",porcentajeGanados);
Console.WriteLine("El porcentaje de estudiantes que perdieron la asignatura es {0} %\n",porcentajePerdidos);
Console.WriteLine("INFORME NOTAS CON CODIGO:");


for(int i = 0; (i<NumeroTotalEstudiantes); i++){
  Console.WriteLine("El codigo del estudiante es {0}, su nota definitiva es {1}",codigos[i],notas[i]);
  

}

