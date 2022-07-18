// See https://aka.ms/new-console-template for more information
class Escuela
{
    public string ?nombre; //si se pone publico se puede modificar desde afuera de la clase
    public string ?direccion;
    public int añoFundacion;
    public string ?ceo;

    //el VOID es una acción o un método, solo hace algo pero no me regresa ningun valor
    public void Timbrar()
    {
        //To do
                        //  miliseg
        Console.Beep(2000,3000);
    }
}

class Program
{
    static void Main (String []args)
    {
        var miEscuela = new Escuela();
        miEscuela.nombre = "PLATZI ACADEMY";
        miEscuela.direccion = "Cra 123 #23-33";
        miEscuela.añoFundacion = 2012;
        
        Console.WriteLine("Timbrando");
        miEscuela.Timbrar();
    }
}

 