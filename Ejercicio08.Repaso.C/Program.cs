namespace Ejercicio08.Repaso.C
{

    class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("INTRODUCE UNA FRASE: ");
            string frasePrimeraUsu = Console.ReadLine();

            Console.WriteLine(frasePrimeraUsu);


            Console.WriteLine("INTRODUZCA UN CARACTER A REEMPLAZAR DE LA FRASE");
            char caracterPrimeroAReemplazar = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("CARACTER A REEMPLAZAR");
            char caracterReemplazado = Convert.ToChar(Console.ReadLine());


            string fraseModificada =  frasePrimeraUsu.Replace(caracterPrimeroAReemplazar, caracterReemplazado);

            Console.WriteLine(fraseModificada);

       

           





        }

    }


}


