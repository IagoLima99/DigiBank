using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Classes
{
    public class Layout
    {
        private static int opcao = 0;

        public static void TelaPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();


            Console.WriteLine("                                                                             ");
            Console.WriteLine("                       Digite a Opção Desejada :                             ");
            Console.WriteLine("                      ===============================                        ");
            Console.WriteLine("                       1 - Criar Conta                                       ");
            Console.WriteLine("                      ===============================                        ");
            Console.WriteLine("                       2 - Entrar com CPF e Senha                            ");
            Console.WriteLine("                      ===============================                        ");



            //var input = Console.ReadLine();
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    TelaCriarConta();
                    break;
                case 2:
                    TelaLogin();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;  
            }
        }

        private static void TelaCriarConta()
        {
            Console.Clear();

            Console.WriteLine("                                                                             ");
            Console.WriteLine("                       Digite seu nome:                                      ");
            String nome = Console.ReadLine();
            Console.WriteLine("                      ===============================                        ");
            Console.WriteLine("                       1 - Digite o CPF:                                     ");
            String cpf = Console.ReadLine();   
            Console.WriteLine("                      ===============================                        ");
            Console.WriteLine("                       2 - Digite sua senha:                                 ");
            String senha = Console.ReadLine();
            Console.WriteLine("                      ===============================                        ");

            Console.WriteLine(nome);
            Console.WriteLine(cpf);
            Console.WriteLine(senha);



        }

        private static void TelaLogin()
        {
            Console.Clear();

            
            Console.WriteLine("                       1 - Digite o CPF:                                     ");
            Console.WriteLine("                      ===============================                        ");
            string cpf = Console.ReadLine();
            Console.WriteLine("                       2 - Digite sua senha:                                 ");
            string senha  = Console.ReadLine();
            Console.WriteLine("                      ===============================                        ");

        }

    }
}
