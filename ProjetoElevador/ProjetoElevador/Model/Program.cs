using System;
using ProjetoElevador.Model;

namespace ProjetoElevador.Model
{
    public class Program : Elevador //trazer dados da classe Elevador (herança/encapsulamento)
    {
        static void Main(string[] args)
        {
            //instanciação daclasse
            Elevador elevador = new Elevador();


            //chamando os métodos para inciiar
            Inicializar();
            MenuInicial();
            int opcao1 = int.Parse(Console.ReadLine());

            Console.Clear(); //comando para limpar a tela
            if (opcao1 == 3)
            {

                Finalizar();

            }
            if (opcao1 == 1)
            {

                Entrar();
                AndaresMenu();

            }

            do 
            {
                 Console.Clear();
                 if (opcao1 == 2)
                 {

                     OpcaoSair();

                         if (opcao1 == 3)
                         {

                             Finalizar();

                         }
                 }



            } while (true);


            Console.Read();
        }
    }
}
