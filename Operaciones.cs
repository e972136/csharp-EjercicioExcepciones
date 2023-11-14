namespace Gaspar{
    public class Operaciones{
 
        public void suma(double numero1, double numero2){
            double respuesta = numero1 + numero2;
            Console.WriteLine($"La suma es: {respuesta}");
        }
        public void resta(double numero1, double numero2){
            double respuesta = numero1 - numero2;
            Console.WriteLine($"La resta es: {respuesta}");
        }
        public void multiplicacion(double numero1, double numero2){
            double respuesta = numero1 * numero2;
            Console.WriteLine($"La multiplicacion es: {respuesta}");
        }
        public void division(double numero1, double numero2){
            double respuesta = 0;
            try{
                respuesta = numero1 / numero2;
            }catch(Exception e){
               Console.WriteLine(e.Message);
            }
            
            Console.WriteLine($"La division es: {respuesta}");
        }

    }
}