using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Data;

namespace PALELUNA
{
    internal class Program
    {

        static List<string> itensColetados = new List<string>();
        static bool buracoCavado = false;
        static bool ouroEnterrado = false;
        static bool buracoTampado = false;
        static void Main(string[] args)
        {

            Inicio();
        }

        static void Inicio()
        {

            Console.WriteLine("PALE LUNA");
            Console.WriteLine("1 - Jogar             2 - Sair");
            Console.WriteLine("==================================");
            var escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
                Jogo();
            else
                Environment.Exit(0);

            Console.Clear();


        }

        static void Jogo()
        {

            Console.Clear();


            Console.WriteLine("Você está em uma sala escura. A luz da lua brilha pela janela.");
            Console.WriteLine("Há OURO no canto, junto de uma PÁ e uma CORDA, também há uma PORTA para o LESTE.");
            Console.WriteLine("Comando ?");



            while (itensColetados.Count < 3)
            {
                string comando = Console.ReadLine().ToLower();

                if (comando == "pegar ouro")
                {
                    if (!itensColetados.Contains("ouro"))
                    {
                        itensColetados.Add("ouro");
                        Console.WriteLine("Você pegou o OURO.");
                    }
                    else
                    {
                        Console.WriteLine("Você já pegou esse item.");
                    }
                }
                else if (comando == "pegar pá" || comando == "pegar pa")
                {
                    if (!itensColetados.Contains("pá"))
                    {
                        itensColetados.Add("pá");
                        Console.WriteLine("Você pegou a PÁ.");
                    }
                    else
                    {
                        Console.WriteLine("Você já pegou esse item.");
                    }
                }
                else if (comando == "pegar corda")
                {
                    if (!itensColetados.Contains("corda"))
                    {
                        itensColetados.Add("corda");
                        Console.WriteLine("Você pegou a CORDA.");
                    }
                    else
                    {
                        Console.WriteLine("Você já pegou esse item.");
                    }
                }
                else
                {
                    Console.WriteLine("Comando inválido.  use a palavra pegar e o item que deseja");
                }
            }




            var escolha = Console.ReadLine().ToLower();
            while (escolha != "abrir porta")
            {
                Console.Clear();
                Console.WriteLine("comando inexistente");
                escolha = Console.ReadLine().ToLower();
            }

            Caminhos();




        }


        static void Caminhos()


        {
            Console.Clear();
            Console.WriteLine("Pegue sua recompensa");
            Console.WriteLine("LUA PÁLIDA SORRI PARA VOCÊ");
            Console.WriteLine("Você está em uma floresta. Há caminhos para NORTE, LESTE e OESTE");
            Console.WriteLine("Comando ?");



            while (true)
            {
                var escolha = Console.ReadLine().ToLower();
                if (escolha == "usar ouro")
                {
                    if (itensColetados.Contains("ouro"))
                    {
                        Console.WriteLine("Aqui não...");
                        escolha = Console.ReadLine().ToLower(); ;

                    }
                    else
                    {
                        Console.WriteLine("Você não tem o item");
                        escolha = Console.ReadLine().ToLower();

                    }
                }
                if (escolha == "usar corda")
                {
                    if (itensColetados.Contains("corda"))
                    {
                        Console.WriteLine("Você já usou isso...");
                        escolha = Console.ReadLine().ToLower();

                    }
                }
                if (escolha == "usar pa" || escolha == "usar pá")
                {
                    if (itensColetados.Contains("pá"))
                    {
                        Console.WriteLine("Aqui não...");
                        escolha = Console.ReadLine().ToLower();
                    }
                }

                if (escolha == "norte")
                {
                    Caminhos2();
                }
                else
                {
                    Inicio();
                }

            }

        }


        static void Caminhos2()
        {

            Console.WriteLine("Você está em uma floresta. Há caminhos para NORTE, LESTE e OESTE");
            Console.WriteLine("Comando ?");
            var escolha = Console.ReadLine().ToLower();

            if (escolha == "leste")
            {
                Caminhos2();
            }
            else if (escolha == "oeste")
            {
                Caminhos3();
            }
            else if (escolha == "norte")
            {
                Inicio();
            }
            else
            {
                Console.WriteLine("Comando invalido");
            }


        }

        static void Caminhos3()
        {

            Console.WriteLine("Você está em uma floresta. Há caminhos para NORTE, LESTE e SUL");
            Console.WriteLine("Comando ?");
            var escolha = Console.ReadLine().ToLower();

            if (escolha == "sul")
            {
                Caminhos4();

            }
            else
            {
                Inicio();
            }
        }

        static void Caminhos4()
        {
            Console.WriteLine("Você está em uma floresta. Há caminhos para OESTE, LESTE e SUL");
            Console.WriteLine("Comando ?");
            var escolha = Console.ReadLine().ToLower();
            if (escolha == "leste")
            {

                Caminhos5();
            }
            else
            {
                Inicio();
            }

        }
        static void Caminhos5()
        {

            Console.WriteLine("Você está em uma floresta. Há caminhos para NORTE, LESTE e SUL");
            Console.WriteLine("Comando ?");
            var escolha = Console.ReadLine().ToLower();

            if (escolha == "sul")
            {

                Caminhos6();

            }
            else
            {
                Inicio();
            }
        }
        static void Caminhos6()
        {
            Console.WriteLine("Você está em uma floresta. Há caminhos para NORTE, LESTE e SUL");
            Console.WriteLine("Comando ?");
            var escolha = Console.ReadLine().ToLower();

            if (escolha == "norte")
            {
                CaminhoFinal();
            }
            else
            {
                Inicio();
            }

        }
        static void CaminhoFinal()
        {
            Console.WriteLine("LUA PÁLIDA SORRI ABERTAMENTE");
            Console.WriteLine("Não há mais caminhos");
            Console.WriteLine("LUA PÁLIDA SORRI ABERTAMENTE");
            Console.WriteLine("O solo está macio");
            Console.WriteLine("LUA PÁLIDA SORRI ABERTAMENTE");
            Console.WriteLine("Aqui");
            Console.WriteLine("Comando?");

            while (true)
            {

                var escolha = Console.ReadLine().ToLower();

                if (escolha == "cavar buraco")
                {
                    if (!buracoCavado)
                    {
                        Console.WriteLine("Você cavou um buraco");
                        buracoCavado = true;
                    }
                }
                else if (escolha == "colocar ouro")
                {
                    if (buracoCavado && !ouroEnterrado)
                    {
                        Console.WriteLine("Você colocou o ouro no buraco");
                        ouroEnterrado = true;
                    }

                }
                else if (escolha == "tampar buraco")
                {
                    if (!buracoTampado)
                    {
                        buracoTampado = true;
                        Console.WriteLine("PARABÉNS");
                        while (buracoCavado && buracoTampado)
                        {

                            Console.WriteLine(@"—— 40.24248 ——

—— -121.4434 ——");

                            break;
                        }
                    }


                }
            }
        }
    }
}

