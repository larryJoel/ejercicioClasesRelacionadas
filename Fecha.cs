using System.Data;
class Fecha{
    int dia;
    int mes;
    int anio;
    public Fecha(int d, int m, int a){
        dia=d;
        mes=m;
        anio=a;
    }
    //diferencia de fechas
    public int diferencia(DateTime f){
        var x = new DateTime (anio, mes, dia);
        var dif = f.Subtract(x);
        return dif.Days; 
    }

    public string mostrarFecha(){
        return dia.ToString() +"/"+mes.ToString()+"/"+anio.ToString();
    }
    public void cumpleanio(int d, int m, int a){
        Fecha f =new Fecha(d, m, a);
        var hoy = DateTime.Today;
        var cumpleDia = f.dia;
        var cumpleMes = f.mes;
        if(hoy.Day == cumpleDia && hoy.Month  == cumpleMes)
        Console.WriteLine("Feliz Cumplaños...!!!!");
    }

    public void mayor(int d, int m, int a){
        Fecha f=new Fecha(d, m,a);
        var anioActual = 2022;
        var cumple = f.anio;
        var mayorEdad = anioActual - cumple;
        if(mayorEdad >= 18)
            Console.WriteLine("Es mayor de edad, tiene: "+ mayorEdad);
            else
            Console.WriteLine("Es menor de edad, tiene: "+mayorEdad);
    }

    public void conocerSigno(int d, int m){
        //Console.WriteLine("Entro en el metodo");
        
        if((m==3 && d >= 21)||(m==4 && d <= 20)) Console.WriteLine("Su signo es: Aries");
        if((m==4 && d >= 21)||(m==5 && d <= 20)) Console.WriteLine("Su signo es: Tauro");
        if((m==5 && d >= 21)||(m==6 && d <= 21)) Console.WriteLine("Su signo es: Geminis");
        if((m==6 && d >= 22)||(m==7 && d <= 21)) Console.WriteLine("Su signo es: Cancer");
        if((m==7 && d >= 22)||(m==8 && d <= 22)) Console.WriteLine("Su signo es: Leo");
        if((m==8 && d >= 23)||(m==9 && d <= 22)) Console.WriteLine("Su signo es: Virgo");
        if((m==9 && d >= 23)||(m==10 && d <= 22)) Console.WriteLine("Su signo es: Libra");
        if((m==10 && d >= 23)||(m==11 && d <= 22)) Console.WriteLine("Su signo es: Escorpion");
        if((m==11 && d >= 23)||(m==12 && d <= 21)) Console.WriteLine("Su signo es: Sagitario");
        if((m==12 && d >= 22)||(m==1 && d <= 20)) Console.WriteLine("Su signo es: Capricornio");
        if((m==1 && d >= 21)||(m==2 && d <= 19)) Console.WriteLine("Su signo es: Acuario");
        if((m==2 && d >= 20)||(m==3 && d <= 20)) Console.WriteLine("Su signo es: Pisis");
    }
}