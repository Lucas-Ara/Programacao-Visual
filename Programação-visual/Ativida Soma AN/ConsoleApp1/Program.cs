class Program
{
 

    public static void Main(string[] args)
    {
        int a, n, resultado;


        Console.WriteLine("Soma (AN) ");
        Console.WriteLine("Digite um numero: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um numero: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int cont = a;
        resultado = 0;
        for (int i = 0; i < n; i++)
        {
            cont = cont + (a + i);
            int aux = a + i;
            resultado = resultado + aux;
            Console.WriteLine(aux);
            

        }
        

        Console.WriteLine(String.Format("O resultado da soma é: {0}", resultado));
        Console.ReadKey();
    }
}


