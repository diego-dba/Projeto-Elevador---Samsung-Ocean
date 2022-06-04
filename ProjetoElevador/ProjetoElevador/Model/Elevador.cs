using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public class Elevador
    {   //Atributos do elevador
        public static int AndarAtual { get; set; }
        public static int TotalAndares { get; set; }
        public static int Capacidade { get; set; }
        public static int QtdePaxAtual { get; set; }

        public static string QtdPax = ("Atualmente há um total de " + QtdePaxAtual + " pessoas.");

        //Métodos a executar
        public static void Inicializar()
        {
            //msg de boas vindas e perguntar capacidade do elevador a utilizar
            Console.WriteLine("Olá. Te dou as boas vindas!");
            Capacidade = 6;


            // total de andares do prédio
            TotalAndares = 3;
            Console.Clear();

            AndarAtual = 0;

            //Quantidade atual de pessoas
            QtdePaxAtual = 0;

            Console.WriteLine("Estamos em um prédio de " + TotalAndares + " andares" + " e o elevador tem capacidade para " + Capacidade + " pessoas.");


        }
        //Menu de interação com o usuário
        public static void MenuInicial()
        {

            Console.WriteLine("O que você deseja fazer?\n" +
                "1 - Entrar\n" +
                "2 - Sair\n" +
                "3 - Finalizar programa\n");


        }

        //Menu de interação para escolha dos andares pelo usuário
        public static void AndaresMenu()
        {
            Console.WriteLine("Para qual andar você deseja ir?");
            Console.WriteLine("0- Térreo\n" +
                "1 - Primeiro\n" +
                "2 - Segundo\n" +
                "3 - Terceiro\n");



        }
        //Achei mais simples colocar os dois métodos em umm só para reaproveitar
        //Assim consigo amarrar com os demais métodos
        public static void SubirDescer()
        {
            Console.Clear();
            Console.WriteLine("Por favor, informe em qual andar estamos:");
            Console.WriteLine("0- Térreo\n" +
                                "1 - Primeiro\n" +
                                "2 - Segundo\n" +
                                "3 - Terceiro\n");
            int andarAtual = int.Parse(Console.ReadLine());

            Console.Clear();
            //função importante para um output mais clean pro user
            switch (andarAtual)
            {
                case 0: Console.WriteLine("Estamos no andar 0 - Térreo."); break;
                case 1: Console.WriteLine("Estamos no andar 1 - Primeiro."); break;
                case 2: Console.WriteLine("Estamos no andar 2 - Segundo"); break;
                case 3: Console.WriteLine("Estamos no andar 3 - Terceiro"); break;
                default: MenuNovaEscolha(); break;


            }

            //apresentar o menu de andares ao usuário para que ele escolha
            AndaresMenu();
            int andarEscolhido = int.Parse(Console.ReadLine());

            Console.Clear();
            //comparar se o andar escolhido não é o mesmo ou se está fora das opções disponíveis
            if (andarEscolhido == andarAtual)

            {
                Console.WriteLine("Opa! Já estamos nesse andar.");
                MenuNovaEscolha();
                andarEscolhido = int.Parse(Console.ReadLine());

            }
            else if (andarEscolhido != andarAtual)
            {
                //função importante para um output mais clean pro user
                switch (andarEscolhido)
                {
                    case 0: Console.WriteLine("Você escolheu o andar 0 - Térreo."); break;
                    case 1: Console.WriteLine("Você escolheu o andar 1 - Primeiro."); break;
                    case 2: Console.WriteLine("Você escolheu o andar 2 - Segundo"); break;
                    case 3: Console.WriteLine("Você escolheu o andar 3 - Terceiro"); break;
                    default: MenuNovaEscolha(); break;


                }

            }
            if (andarEscolhido < 0)
            {
                Console.Clear();
                Console.WriteLine("Opção inválida");
                MenuNovaEscolha();

            }
            else if (andarEscolhido > 3)
            {

                Console.Clear();
                Console.WriteLine("Opção inválida");
                MenuNovaEscolha();

            }
            //Mensagem de entreternimento (pode ser alterada por um anúncio ou outro meio)
            Console.WriteLine("Estamos a caminho...");
            Console.WriteLine("Chegamos!");
            Console.WriteLine("Foi bom passear com você.");
            //o que deseja fazer? e por o metodo sair
            //Console.WriteLine("Antes de finalizar, por favor, me informe o total de pessoas restantes no elevador:");

            //int qntPaxAtual = int.Parse(Console.ReadLine());
            Finalizar();


        }

        //Diferente do menu inicial, a fim de manter coerência com as escolhas do user
        public static void MenuNovaEscolha()
        {

                MenuInicial();
                int andarInfo = int.Parse(Console.ReadLine());
                Console.Clear();
                if (andarInfo == 2)
                {

                OpcaoSair(); //se o user escolher essa oção, esse método é acionado

                }
                if (andarInfo == 3)
                {

                    Finalizar(); //se o user escolher essa oção, esse método é acionado
                }
                else if (andarInfo == 1)
                {



                }
        }

        public static void OpcaoSair()
        {

            int opcao1 = 0;

            do
            {   //Caso o usuário aperte a opção sem estar realmente dentro do elevador, o loop fará ele rever sua ação.
                Console.WriteLine("Você ainda não entrou, por favor siga com as opções:");
                MenuNovaEscolha();
                opcao1 = int.Parse(Console.ReadLine());

            } while (opcao1 == 2);
                Console.Clear();
                if (opcao1 == 3)
                {

                    Finalizar();

                }




        }
        public static void Entrar()
        {//impedir que entre mais pessoas do que a capacidade máxima

            Console.WriteLine("Quantas pessoas vão com você?");
            int qntPaxInfo = int.Parse(Console.ReadLine());
            Console.Clear();
            if (qntPaxInfo >= 6)
            {

                Console.WriteLine("Por favor, tente novamente em alguns minutos. Nossa capacidade máxima é de 6 pessoas.");
                Finalizar();
            }
            else if (qntPaxInfo < 0)
            {

                Console.WriteLine("Ao menos uma pessoa precisa entrar. Por favor, tente novamente em alguns minutos.");
                Finalizar();
            }
            
            if (qntPaxInfo < 6)
            {

                SubirDescer();
            }
                

        }


        public static void Sair()
        {   //impedir que saiam mais pessoas do que o existente
            Console.WriteLine("Quantas pessoas sairam elevador?");
            int QtdePaxOut = int.Parse(Console.ReadLine());
            Console.WriteLine("Entraram quantas pessoas no elevador?");
            int QtdePaxIn = int.Parse(Console.ReadLine());
            QtdePaxAtual = QtdePaxOut - QtdePaxIn;

            if (QtdePaxAtual > 6)
            {

                Console.WriteLine("Por favor, aguarde. Nossa capacidade máxima é de 6 pessoas.");
                Finalizar();

            }

            else if (QtdePaxAtual <= 0)
            {

                Console.WriteLine("O elevador está vazio. É preciso ao menos uma pessoa para descer. Por favor, cheque as informações e tente novamente.");
                Finalizar();

            }
            if (QtdePaxAtual < 6)
            {

                SubirDescer();

            }
        }
        //Método caso o user opte por desistir de utilizar o aapp
        public static void Finalizar()
        {


            Console.WriteLine("Obrigado e até breve!");
            Environment.Exit(0);
            Console.Clear();


        }

    }

}
