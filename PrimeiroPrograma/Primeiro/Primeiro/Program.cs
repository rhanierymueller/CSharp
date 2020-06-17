// referencência para o namespace System 
using System;

//Namespace é um agrupamento de classes relacionadas
namespace Primeiro
{
    //Classe é aunidade básica da programação orientação a objetos
    class Program
    {
        //Aqui podemos ter membros da classe
        
        //EntrePoint -> point de entrada para saber aonde a execução começa
        static void Main(string[] args)
        {
            //Para usar o comando Console precisa usar o namespace System, pois ele pertence ao System.
            Console.WriteLine("Hello World!");
        }
    }
}