
using Gaspar;
try{
    Console.Write("Numero 1: ");
    double numero1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Numero 2: ");
    double numero2 = Convert.ToDouble(Console.ReadLine());

    Operaciones o = new Operaciones();

    o.suma(numero1,numero2);
    o.resta(numero1,numero2);
    o.multiplicacion(numero1,numero2);
    o.division(numero1,numero2);

}catch(Exception e){
    Console.WriteLine(e.Message);
}



