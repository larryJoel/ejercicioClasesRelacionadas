using System.Security.Claims;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Linq.Expressions;
internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Persona una = new Persona("Luis", "Medina", 35, 09, 11, 2018, "1150297493");
        //Console.WriteLine(una.ToString());
        int cont =0;
        Console.Write("Agregue la cantidad de registros:");
        cont = int.Parse(Console.ReadLine());

        //contar cantidad de amigos que cumplen en un mes en particular
        Console.Write("Ingrese mes:");
        int mesAVer = int.Parse(Console.ReadLine());
        int contador=0;
       
        Persona[] amigo = new Persona[cont];
            var nombre="";
            var apellido="";
            int edad = 0;
            int dia = 1;
            int mes = 2;
            int anio = 9999;
            var dni = "";

     
        for (int i = 0; i < amigo.Length; i++)
        {
            Console.Write("Nombre del amigo: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido del amigo: ");
            apellido = Console.ReadLine();
            Console.Write("edad del amigo: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("dia nacimiento del amigo: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("mes nacimiento del amigo: ");
            mes = int.Parse(Console.ReadLine());
            if(mesAVer == mes) contador++;
            Console.Write("año nacimiento del amigo: ");
            anio = int.Parse(Console.ReadLine());
             
            Console.Write("Telefono del amigo: ");
            dni = Console.ReadLine();
            amigo[i] = new Persona(nombre, apellido, edad, dia, mes, anio, dni);
          
            //amigo[0]=new Persona("juan","pedrosa",23,09,10,2018,"12336203");
        }
            Console.WriteLine("*************************************");
        foreach (Persona p in amigo)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine(p.ToString());
            Fecha cumple = new Fecha(dia, mes, anio);
            cumple.cumpleanio(dia,mes, anio);
            cumple.mayor(dia,mes, anio);
            cumple.conocerSigno(dia, mes);
            Console.WriteLine($"La cantidad de amigos que cumple en {mesAVer}, es(son): {contador}");
        }
      
    }
}
//amigo[0]=new Persona("juan","pedrosa",23,09,10,2018,"12336203");
