class Persona{
    string nombre;
    string apellido;
    int edad;
    Fecha fechaNacimiento;
    string telefono;
    public Persona(string n, string a, int ed, int dia, int mes, int anio, string telf){
        nombre=n;
        apellido=a;
        edad=ed;
        fechaNacimiento=new Fecha(dia, mes, anio);
        fechaNacimiento.cumpleanio(dia,mes,anio);
        telefono=telf;
    }
    
    
    //mensajes a mostrar en pantalla
    public override string ToString()
    {
        return $"Nombre completo:{apellido}, {nombre}. Edad: {edad}, nacio el:{fechaNacimiento.mostrarFecha()}, telefono: {telefono}";
    }
}