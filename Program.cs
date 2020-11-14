using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade");
            int idade = int.Parse(Console.ReadLine());
            if(idade>=5  & idade<=7){
                System.Console.WriteLine("Categoria Infantil A");
            }else if(idade>=8  & idade<=10){
                System.Console.WriteLine("Categoria Infantil B");
            }else if(idade>=11  & idade<=13){
                System.Console.WriteLine("Categoria Juvenil A");
            }else if(idade>=14  & idade<=17){
                System.Console.WriteLine("Categoria Juvenil B");
            }else if(idade>18){
                System.Console.WriteLine("Categoria Sênior");
            }else{
                System.Console.WriteLine("Não possui Categoria");
            }
        }
    }
}
