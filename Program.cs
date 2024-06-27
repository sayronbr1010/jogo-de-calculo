using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

//Este sistema é uma espécie de jogo para testar seus conhecimentos de matemática
//Ele fornece um número e operações para chegar até ele.
namespace jogo_de_calculo
{
    internal class Program
    {
        enum operacoes { adição=1, subtração, Divisao, multiplicação, Potencia }
        enum opcoa { Jogar = 1, Sair, Funcionamento }
        //Cria 2 variáveis que são utilizadas para definir as operações e as opções do jogo
        static void Main(string[] args)
        {
            Console.Title = "jogo de calculo";
            int saida = 0;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            do
            {
                Linha();
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("1-Jogar\t 2-Sair\n3-Funcionamento");
                int index = int.Parse(Console.ReadLine());
                Linha();
                opcoa opcoaselecionada1 = (opcoa)index;
                switch (opcoaselecionada1)
                {
                    case opcoa.Jogar:
                        List<double> NumerosConta = new List<double>();
                        List<double> Numero_obrigatorio = new List<double>();
                        double verifica1;
                        double verifica2;
                        double verifica3;
                        double resultado = 2056490130;
                        int posicao = 0;
                        int Tam_max_sort;
                        List<operacoes> OpSelecionados = new List<operacoes>();
                        List<int> OpEscolhlida = new List<int>();
                        Random rnd = new Random();
                        int EscolheOp;
                        double numero;
                        bool saida_de_jogo = true;
                        bool erro_de_digitacao = false;
                        string opcoaselecionada;
                        List<operacoes> vericacao = new List<operacoes>();

                        do
                        {
                            Console.WriteLine("Escolha a dificuldade :");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("1-Normal");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("    2-Difícil");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            int dificudade = int.Parse(Console.ReadLine());
                            if (dificudade == 2)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    EscolheOp = rnd.Next(1, 5);
                                    OpSelecionados.Add((operacoes)EscolheOp);
                                    vericacao.Add((operacoes)EscolheOp);
                                }
                                Console.WriteLine("Escolha o número maximo a ser sorteado :");
                                Tam_max_sort = int.Parse(Console.ReadLine());
                                Linha();
                                int objetivo = rnd.Next(1, Tam_max_sort);
                                numero = rnd.Next(1, Tam_max_sort);
                                Console.Write("Você tem que chegar ao resultado ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(objetivo);
                                Console.ForegroundColor= ConsoleColor.Gray;
                                Console.WriteLine("Usando somente:");
                                OpSelecionados.Sort();
                                foreach (var item in OpSelecionados)
                                {
                                    if (vericacao.IndexOf(operacoes.adição) != -1)
                                    {
                                        vericacao.Remove(operacoes.adição);
                                        if (vericacao.IndexOf(operacoes.adição) != -1)
                                        {
                                            vericacao.Remove(operacoes.adição);
                                            if (vericacao.IndexOf(operacoes.adição) != -1)
                                            {
                                                vericacao.Remove(operacoes.adição);
                                                if (vericacao.IndexOf(operacoes.adição) != -1)
                                                {
                                                    Console.WriteLine("Quatro adições");
                                                }
                                                else { Console.WriteLine("Três adições"); }
                                            }
                                            else { Console.WriteLine("Duas adições"); }
                                        }
                                        else { Console.WriteLine("Uma adição"); }
                                    }
                                    if (vericacao.IndexOf(operacoes.subtração) != -1)
                                    {
                                        vericacao.Remove(operacoes.subtração);
                                        if (vericacao.IndexOf(operacoes.subtração) != -1)
                                        {
                                            vericacao.Remove(operacoes.subtração);
                                            if (vericacao.IndexOf(operacoes.subtração) != -1)
                                            {
                                                vericacao.Remove(operacoes.subtração);
                                                if (vericacao.IndexOf(operacoes.subtração) != -1)
                                                {
                                                    Console.WriteLine("Quatro subtrações");
                                                }
                                                else { Console.WriteLine("Três subtrações"); }
                                            }
                                            else { Console.WriteLine("Duas subtrações"); }
                                        }
                                        else { Console.WriteLine("Uma subtração"); }
                                    }
                                    if (vericacao.IndexOf(operacoes.Divisao) != -1)
                                    {
                                        vericacao.Remove(operacoes.Divisao);
                                        if (vericacao.IndexOf(operacoes.Divisao) != -1)
                                        {
                                            vericacao.Remove(operacoes.Divisao);
                                            if (vericacao.IndexOf(operacoes.Divisao) != -1)
                                            {
                                                vericacao.Remove(operacoes.Divisao);
                                                if (vericacao.IndexOf(operacoes.Divisao) != -1)
                                                {
                                                    Console.WriteLine("Quatro divisões");
                                                }
                                                else { Console.WriteLine("Três divisões"); }
                                            }
                                            else { Console.WriteLine("Duas divisões"); }
                                        }
                                        else { Console.WriteLine("Uma divisao"); }
                                    }
                                    if (vericacao.IndexOf(operacoes.multiplicação) != -1)
                                    {
                                        vericacao.Remove(operacoes.multiplicação);
                                        if (vericacao.IndexOf(operacoes.multiplicação) != -1)
                                        {
                                            vericacao.Remove(operacoes.multiplicação);
                                            if (vericacao.IndexOf(operacoes.multiplicação) != -1)
                                            {
                                                vericacao.Remove(operacoes.multiplicação);
                                                if (vericacao.IndexOf(operacoes.multiplicação) != -1)
                                                {
                                                    Console.WriteLine("Quatro multiplicações");
                                                }
                                                else { Console.WriteLine("Três multiplicações"); }
                                            }
                                            else { Console.WriteLine("Duas multiplicações"); }
                                        }
                                        else { Console.WriteLine("Uma multiplicação"); }
                                    }
                                    if (vericacao.IndexOf(operacoes.Potencia) != -1)
                                    {
                                        vericacao.Remove(operacoes.Potencia);
                                        if (vericacao.IndexOf(operacoes.Potencia) != -1)
                                        {
                                            vericacao.Remove(operacoes.Potencia);
                                            if (vericacao.IndexOf(operacoes.Potencia) != -1)
                                            {
                                                vericacao.Remove(operacoes.Potencia);
                                                if (vericacao.IndexOf(operacoes.Potencia) != -1)
                                                {
                                                    Console.WriteLine("Quatro potenciações");
                                                }
                                                else { Console.WriteLine("Três potenciações"); }
                                            }
                                            else { Console.WriteLine("Duas potenciações"); }
                                        }
                                        else { Console.WriteLine("Uma potenciação"); }
                                    }
                                }

                                Console.WriteLine("E usando o número " + numero);
                                Linha();
                                Console.WriteLine("Escolha um número ");
                                verifica1 = int.Parse(Console.ReadLine());
                                Numero_obrigatorio.Add(verifica1);
                                NumerosConta.Add(verifica1);
                                for (int i = 0; i > -1; i++)
                                {

                                    if (verifica1 == 2056490130)
                                    {
                                        i = 4;
                                    }
                                    else
                                    {
                                        do
                                        {
                                            Linha();
                                            Console.Write("Você tem que chegar ao resultado ");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine(objetivo);
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Linha();
                                            Console.WriteLine("Por favor, escolha uma das operações.");
                                            foreach (int p in OpSelecionados)
                                            {
                                                switch (p)
                                                {
                                                    case 1:
                                                        Console.WriteLine("+ para Adição");
                                                        break;
                                                    case 2:
                                                        Console.WriteLine("- para Subtração");
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("/ para Divisao");
                                                        break;
                                                    case 4:
                                                        Console.WriteLine("* para Multiplicação");
                                                        break;
                                                    case 5:
                                                        Console.WriteLine("^ para Elevado");
                                                        break;
                                                }
                                            }
                                            opcoaselecionada = Console.ReadLine();
                                            if (opcoaselecionada != "+" && opcoaselecionada != "-" && opcoaselecionada != "/" && opcoaselecionada != "*" && opcoaselecionada != "^")
                                            {
                                                Console.WriteLine("Opção inválida.");
                                                erro_de_digitacao = true;
                                            }
                                            else
                                            {
                                                erro_de_digitacao = false;
                                            }
                                        }
                                        while (erro_de_digitacao);
                                    Console.WriteLine("Escolha o próximo número.");
                                        verifica2 = double.Parse(Console.ReadLine());
                                        Numero_obrigatorio.Add(verifica2);  
                                        Linha();
                                        if (verifica2 == 2056490130)
                                        {
                                            i = 4;
                                        }
                                        else
                                        {
                                            NumerosConta.Add(verifica2);
                                            Console.Clear();
                                            switch (opcoaselecionada)
                                            {
                                                case "+":
                                                    if (OpSelecionados.IndexOf(operacoes.adição) != -1)
                                                    {
                                                        verifica3 = resultado;
                                                        resultado = adicao(NumerosConta[posicao], NumerosConta[posicao + 1]);
                                                        Console.WriteLine("\n\n\nO resustado de " + NumerosConta[posicao] + "+" + NumerosConta[posicao + 1] + " é " + resultado + "\n");
                                                        if (verifica3 == NumerosConta[posicao]) { NumerosConta.Remove(verifica3); }
                                                        NumerosConta.Remove(verifica2);
                                                        NumerosConta.Remove(verifica1);
                                                        NumerosConta.Add(resultado);
                                                        OpSelecionados.Remove(operacoes.adição);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Operação inválida. Preste atenção nas operações restantes.");
                                                    }
                                                    break;
                                                case "-":
                                                    if (OpSelecionados.IndexOf(operacoes.subtração) != -1)
                                                    {
                                                        verifica3 = resultado;
                                                        resultado = subitracao(NumerosConta[posicao], NumerosConta[posicao + 1]);
                                                        Console.WriteLine("\n\n\nO resustado de " + NumerosConta[posicao] + "-" + NumerosConta[posicao + 1] + " é " + resultado + "\n");
                                                        if (verifica3 == NumerosConta[posicao]) { NumerosConta.Remove(verifica3); }
                                                        NumerosConta.Remove(verifica2);
                                                        NumerosConta.Remove(verifica1);
                                                        NumerosConta.Add(resultado);
                                                        OpSelecionados.Remove(operacoes.subtração);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Operação inválida. Preste atenção nas operações restantes.");
                                                    }
                                                    break;
                                                case "/":
                                                    if (OpSelecionados.IndexOf(operacoes.Divisao) != -1)
                                                    {
                                                        verifica3 = resultado;
                                                        resultado = divicao(NumerosConta[posicao], NumerosConta[posicao + 1]);
                                                        Console.WriteLine("\n\n\nO resustado de " + NumerosConta[posicao] + "/" + NumerosConta[posicao + 1] + " é " + resultado + "\n");
                                                        if (verifica3 == NumerosConta[posicao]) { NumerosConta.Remove(verifica3); }
                                                        NumerosConta.Remove(verifica2);
                                                        NumerosConta.Remove(verifica1);
                                                        NumerosConta.Add(resultado);
                                                        OpSelecionados.Remove(operacoes.Divisao);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Operação inválida. Preste atenção nas operações restantes.");
                                                    }
                                                    break;
                                                case "*":
                                                    if (OpSelecionados.IndexOf(operacoes.multiplicação) != -1)
                                                    {
                                                        verifica3 = resultado;
                                                        resultado = mutiplicacao(NumerosConta[posicao], NumerosConta[posicao + 1]);
                                                        Console.WriteLine("\n\n\nO resustado de " + NumerosConta[posicao] + "x" + NumerosConta[posicao + 1] + " é " + resultado + "\n");
                                                        if (verifica3 == NumerosConta[posicao]) { NumerosConta.Remove(verifica3); }
                                                        NumerosConta.Remove(verifica2);
                                                        NumerosConta.Remove(verifica1);
                                                        NumerosConta.Add(resultado);
                                                        OpSelecionados.Remove(operacoes.multiplicação);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Operação inválida. Preste atenção nas operações restantes.");
                                                    }
                                                    break;
                                                case "^":
                                                    if (OpSelecionados.IndexOf(operacoes.Potencia) != -1)
                                                    {
                                                        verifica3 = resultado;
                                                        resultado = Math.Pow(NumerosConta[posicao], NumerosConta[posicao + 1]);
                                                        Console.WriteLine("\n\n\nO resustado de " + NumerosConta[posicao] + "x" + NumerosConta[posicao + 1] + " é " + resultado + "\n");
                                                        if (verifica3 == NumerosConta[posicao]) { NumerosConta.Remove(verifica3); }
                                                        NumerosConta.Remove(verifica2);
                                                        NumerosConta.Remove(verifica1);
                                                        NumerosConta.Add(resultado);
                                                        OpSelecionados.Remove(operacoes.Potencia);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Operação inválida. Preste atenção nas operações restantes.");
                                                    }
                                                    break;
                                            }
                                        }
                                        if (resultado == objetivo && OpSelecionados.Count == 0 && Numero_obrigatorio.IndexOf(numero) !=-1)
                                        {
                                            i = -2056490130;
                                            NumerosConta.Remove(resultado);
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("          _______  _______  _______    _______  _______  _                 _______          ");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.Write("|\\     /|(  ___  )(  ____ \\(  ____ \\  (  ____ \\(  ___  )( (    /||\\     /|(  ___  )|\\     /|\r\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("| )   ( || (   ) || (    \\/| (    \\/  | (    \\/| (   ) ||  \\  ( || )   ( || (   ) || )   ( |\r\n");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("| |   | || |   | || |      | (__      | |      | (___) ||   \\ | || (___) || |   | || |   | |\r\n");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("( (   ) )| |   | || |      |  __)     | | ____ |  ___  || (\\ \\) ||  ___  || |   | || |   | |\r\n");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.Write(" \\ \\_/ / | |   | || |      | (        | | \\_  )| (   ) || | \\   || (   ) || |   | || |   | |\r\n");
                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                            Console.Write("  \\   /  | (___) || (____/\\| (____/\\  | (___) || )   ( || )  \\  || )   ( || (___) || (___) |\r\n");
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.Write("   \\_/   (_______)(_______/(_______/  (_______)|/     \\||/    )_)|/     \\|(_______)(_______)\r\n");
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("Deseja jogar novamente?");
                                            Console.WriteLine("1-Sim             2-Não");
                                            saida = int.Parse(Console.ReadLine());
                                            Linha();
                                            if (saida == 2)
                                            {
                                                saida_de_jogo = false;
                                            }
                                        }
                                        else if (OpSelecionados.Count == 0 && Numero_obrigatorio.IndexOf(numero) != -1)
                                        {
                                            NumerosConta.Remove(resultado);
                                            i = -2056490130;
                                            Console.WriteLine("O objetivo era chegar a " + objetivo + " e você chegou a " + resultado + ".");
                                            Console.WriteLine("Infelizmente, você perdeu.");
                                            Console.WriteLine("Deseja jogar novamente?");
                                            Console.WriteLine("1-Sim             2-Não");
                                            saida = int.Parse(Console.ReadLine());
                                            Linha();
                                            if (saida == 2)
                                            {
                                                saida_de_jogo = false;
                                            }
                                        }
                                        else if (resultado == objetivo && OpSelecionados.Count == 0)
                                        {
                                            NumerosConta.Remove(resultado);
                                            i = -2056490130;
                                            Console.WriteLine("O objetivo era chegar a " + objetivo + " e você chegou a " + resultado + ".");
                                            Console.WriteLine("Porém, você esqueceu de usar o número " + numero + ", e como ele é obrigatório, você perdeu.");
                                            Console.WriteLine("Deseja jogar novamente?");
                                            Console.WriteLine("1-Sim             2-Não");
                                            saida = int.Parse(Console.ReadLine());
                                            Linha();
                                            if (saida == 2)
                                            {
                                                saida_de_jogo = false;
                                            }
                                        }



                                    }
                                }

                            }
                            if (dificudade == 1)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    EscolheOp = rnd.Next(1, 4);
                                    OpSelecionados.Add((operacoes)EscolheOp);
                                    vericacao.Add((operacoes)EscolheOp);
                                }
                                Console.WriteLine("Escolha o número maximo a ser sorteado :");
                                Tam_max_sort = int.Parse(Console.ReadLine());
                                Linha();
                                int objetivo = rnd.Next(1, Tam_max_sort);
                                Console.Write("Você tem que chegar ao resultado ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(objetivo);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Usando somente:");
                                OpSelecionados.Sort();
                                foreach (var item in OpSelecionados)
                                {
                                    if (vericacao.IndexOf(operacoes.adição) != -1)
                                    {
                                        vericacao.Remove(operacoes.adição);
                                        if (vericacao.IndexOf(operacoes.adição) != -1)
                                        {
                                            vericacao.Remove(operacoes.adição);
                                            if (vericacao.IndexOf(operacoes.adição) != -1)
                                            {
                                                vericacao.Remove(operacoes.adição);
                                                if (vericacao.IndexOf(operacoes.adição) != -1)
                                                {
                                                    Console.WriteLine("Quatro adições");
                                                }
                                                else { Console.WriteLine("Três adições"); }
                                            }
                                            else { Console.WriteLine("Duas adições"); }
                                        }
                                        else { Console.WriteLine("Uma adição"); }
                                    }
                                    if (vericacao.IndexOf(operacoes.subtração) != -1)
                                    {
                                        vericacao.Remove(operacoes.subtração);
                                        if (vericacao.IndexOf(operacoes.subtração) != -1)
                                        {
                                            vericacao.Remove(operacoes.subtração);
                                            if (vericacao.IndexOf(operacoes.subtração) != -1)
                                            {
                                                vericacao.Remove(operacoes.subtração);
                                                if (vericacao.IndexOf(operacoes.subtração) != -1)
                                                {
                                                    Console.WriteLine("Quatro subtrações");
                                                }
                                                else { Console.WriteLine("Três subtrações"); }
                                            }
                                            else { Console.WriteLine("Duas subtrações"); }
                                        }
                                        else { Console.WriteLine("Uma subtração"); }
                                    }
                                    if (vericacao.IndexOf(operacoes.Divisao) != -1)
                                    {
                                        vericacao.Remove(operacoes.Divisao);
                                        if (vericacao.IndexOf(operacoes.Divisao) != -1)
                                        {
                                            vericacao.Remove(operacoes.Divisao);
                                            if (vericacao.IndexOf(operacoes.Divisao) != -1)
                                            {
                                                vericacao.Remove(operacoes.Divisao);
                                                if (vericacao.IndexOf(operacoes.Divisao) != -1)
                                                {
                                                    Console.WriteLine("Quatro divisões");
                                                }
                                                else { Console.WriteLine("Três divisões"); }
                                            }
                                            else { Console.WriteLine("Duas divisões"); }
                                        }
                                        else { Console.WriteLine("Uma divisao"); }
                                    }
                                    if (vericacao.IndexOf(operacoes.multiplicação) != -1)
                                    {
                                        vericacao.Remove(operacoes.multiplicação);
                                        if (vericacao.IndexOf(operacoes.multiplicação) != -1)
                                        {
                                            vericacao.Remove(operacoes.multiplicação);
                                            if (vericacao.IndexOf(operacoes.multiplicação) != -1)
                                            {
                                                vericacao.Remove(operacoes.multiplicação);
                                                if (vericacao.IndexOf(operacoes.multiplicação) != -1)
                                                {
                                                    Console.WriteLine("Quatro multiplicações");
                                                }
                                                else { Console.WriteLine("Três multiplicações"); }
                                            }
                                            else { Console.WriteLine("Duas multiplicações"); }
                                        }
                                        else { Console.WriteLine("Uma multiplicação"); }
                                    }
                                }
                                Linha();
                                Console.WriteLine("Escolha um número para iniciar a conta");
                                verifica1 = int.Parse(Console.ReadLine());
                                NumerosConta.Add(verifica1);
                                for (int i = 0; i > -1; i++)
                                {
                                    if (verifica1 == 2056490130) { i = 4; }
                                    else
                                    {
                                        do
                                        {
                                            Linha();
                                            Console.Write("Você tem que chegar ao resultado ");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine(objetivo);
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Linha();
                                            Console.WriteLine("Por favor, escolha uma das operações.");
                                            foreach (int p in OpSelecionados)
                                            {
                                                switch (p)
                                                {
                                                    case 1:
                                                        Console.WriteLine("+ para Adição");
                                                        break;
                                                    case 2:
                                                        Console.WriteLine("- para Subtração");
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("/ para Divisão");
                                                        break;
                                                    case 4:
                                                        Console.WriteLine("* para Multiplicação");
                                                        break;
                                                }
                                            }
                                            opcoaselecionada = Console.ReadLine();
                                            if (opcoaselecionada != "+" && opcoaselecionada != "-" && opcoaselecionada != "/" && opcoaselecionada != "*")
                                            {
                                                Console.WriteLine("Opção inválida.");
                                                erro_de_digitacao = true;
                                            }
                                            else
                                            {
                                                erro_de_digitacao = false;
                                            }
                                        }
                                        while (erro_de_digitacao);
                                        Console.WriteLine("Escolha o próximo número.");
                                        verifica2 = double.Parse(Console.ReadLine());
                                        Linha();
                                        if (verifica2 == 2056490130) { i = 4; }
                                        else
                                        {
                                            NumerosConta.Add(verifica2);
                                            Console.Clear();
                                            switch (opcoaselecionada)
                                            {
                                                case "+":
                                                    if (OpSelecionados.IndexOf(operacoes.adição) != -1)
                                                    {
                                                        verifica3 = resultado;
                                                        resultado = adicao(NumerosConta[posicao], NumerosConta[posicao + 1]);
                                                        Console.WriteLine("\n\n\nO resustado de " + NumerosConta[posicao] + "+" + NumerosConta[posicao + 1] + " é " + resultado + "\n");
                                                        if (verifica3 == NumerosConta[posicao]) { NumerosConta.Remove(verifica3); }
                                                        NumerosConta.Remove(verifica2);
                                                        NumerosConta.Remove(verifica1);
                                                        NumerosConta.Add(resultado);
                                                        OpSelecionados.Remove(operacoes.adição);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Operação inválida. Preste atenção nas operações restantes.");
                                                    }
                                                    break;
                                                case "-":
                                                    if (OpSelecionados.IndexOf(operacoes.subtração) != -1)
                                                    {
                                                        verifica3 = resultado;
                                                        resultado = subitracao(NumerosConta[posicao], NumerosConta[posicao + 1]);
                                                        Console.WriteLine("\n\n\nO resustado de " + NumerosConta[posicao] + "-" + NumerosConta[posicao + 1] + " é " + resultado );
                                                        if (verifica3 == NumerosConta[posicao]) { NumerosConta.Remove(verifica3); }
                                                        NumerosConta.Remove(verifica2);
                                                        NumerosConta.Remove(verifica1);
                                                        NumerosConta.Add(resultado);
                                                        OpSelecionados.Remove(operacoes.subtração);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Operação inválida. Preste atenção nas operações restantes.");
                                                    }
                                                    break;
                                                case "/":
                                                    if (OpSelecionados.IndexOf(operacoes.Divisao) != -1)
                                                    {
                                                        verifica3 = resultado;
                                                        resultado = divicao(NumerosConta[posicao], NumerosConta[posicao + 1]);
                                                        Console.WriteLine("\n\n\nO resustado de " + NumerosConta[posicao] + "/" + NumerosConta[posicao + 1] + " é " + resultado + "\n");
                                                        if (verifica3 == NumerosConta[posicao]) { NumerosConta.Remove(verifica3); }
                                                        NumerosConta.Remove(verifica2);
                                                        NumerosConta.Remove(verifica1);
                                                        NumerosConta.Add(resultado);
                                                        OpSelecionados.Remove(operacoes.Divisao);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Operação inválida. Preste atenção nas operações restantes.");
                                                    }
                                                    break;
                                                case "*":
                                                    if (OpSelecionados.IndexOf(operacoes.multiplicação) != -1)
                                                    {
                                                        verifica3 = resultado;
                                                        resultado = mutiplicacao(NumerosConta[posicao], NumerosConta[posicao + 1]);
                                                        Console.WriteLine("\n\n\nO resustado de " + NumerosConta[posicao] + "x" + NumerosConta[posicao + 1] + " é " + resultado + "\n");
                                                        if (verifica3 == NumerosConta[posicao]) { NumerosConta.Remove(verifica3); }
                                                        NumerosConta.Remove(verifica2);
                                                        NumerosConta.Remove(verifica1);
                                                        NumerosConta.Add(resultado);
                                                        OpSelecionados.Remove(operacoes.multiplicação);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Operação inválida. Preste atenção nas operações restantes.");
                                                    }
                                                    break;
                                            }

                                        }
                                        if (resultado == objetivo && OpSelecionados.Count == 0)
                                        {
                                            NumerosConta.Remove(resultado);
                                            i = -2056490130;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("          _______  _______  _______    _______  _______  _                 _______          ");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.Write("|\\     /|(  ___  )(  ____ \\(  ____ \\  (  ____ \\(  ___  )( (    /||\\     /|(  ___  )|\\     /|\r\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("| )   ( || (   ) || (    \\/| (    \\/  | (    \\/| (   ) ||  \\  ( || )   ( || (   ) || )   ( |\r\n");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("| |   | || |   | || |      | (__      | |      | (___) ||   \\ | || (___) || |   | || |   | |\r\n");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("( (   ) )| |   | || |      |  __)     | | ____ |  ___  || (\\ \\) ||  ___  || |   | || |   | |\r\n");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.Write(" \\ \\_/ / | |   | || |      | (        | | \\_  )| (   ) || | \\   || (   ) || |   | || |   | |\r\n");
                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                            Console.Write("  \\   /  | (___) || (____/\\| (____/\\  | (___) || )   ( || )  \\  || )   ( || (___) || (___) |\r\n");
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.Write("   \\_/   (_______)(_______/(_______/  (_______)|/     \\||/    )_)|/     \\|(_______)(_______)\r\n");
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("Deseja jogar novamente?");
                                            Console.WriteLine("1-Sim             2-Não");
                                            saida = int.Parse(Console.ReadLine());
                                            Console.Clear();
                                            if (saida == 2)
                                            {
                                                saida_de_jogo = false;
                                            }
                                            }
                                        else if (OpSelecionados.Count == 0)
                                        {
                                            i = -2056490130;
                                            NumerosConta.Remove(resultado);
                                            Console.WriteLine("O objetivo era chegar a " + objetivo + " e você chegou a " + resultado + ".");
                                            Console.WriteLine("Infelizmente, você perdeu.");
                                            Console.WriteLine("Deseja jogar novamente?");
                                            Console.WriteLine("1-Sim             2-Não");
                                            saida = int.Parse(Console.ReadLine());
                                            Console.Clear();
                                            if (saida == 2)
                                            {
                                                saida_de_jogo = false;
                                            }
                                        }
                                    }
                                }

                            }
                        }
                        while (saida_de_jogo);
                        break;
                    case opcoa.Sair:
                        Console.WriteLine("Dejesa sair mesmo?");
                        Console.WriteLine("1-Sim        2-Não");
                        saida = int.Parse(Console.ReadLine());
                        if (saida == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("VOCÊ DESISTIU DO JOGO.");
                            Console.ForegroundColor= ConsoleColor.Gray;
                        }
                        break;
                    case opcoa.Funcionamento:
                        Console.WriteLine("Este programa é um jogo que testa os seus conhecimentos básicos de matemática, o qual possui duas dificuldades.\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("NORMAL");
                        Console.ForegroundColor= ConsoleColor.Gray;
                        Console.WriteLine(", será sorteado um número para você, o qual você pode escolher o tamanho máximo do número a ser sorteado." );
                        Console.WriteLine("Por exemplo, se você digitar 50, pode ser sorteado qualquer número entre 1 e 50.");
                        Console.WriteLine("Após o número sorteado, serão mostradas três operações matemáticas, que podem ser adição, subtração, divisão ou \nmultiplicação. Você, como jogador, terá que usar todas as operações fornecidas para chegar ao número sorteado. \nÉ importante citar que não necessariamente serão três operações diferentes.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nDIFÍCIL");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(", será sorteado um número para você, o qual você pode escolher o tamanho máximo do número a ser sorteado.");
                        Console.WriteLine("Por exemplo, se você digitar 50, pode ser sorteado qualquer número entre 1 e 50.");
                        Console.WriteLine("Após o número sorteado, serão mostradas quatro operações matemáticas, que podem ser adição, subtração, divisão, \nmultiplicação ou potenciação juntamente com um número. Você, como jogador, terá que usar todas as operações fornecidas \njunto com o número para chegar ao seu objetivo. É importante citar que não necessariamente serão quatro operações \ndiferentes.\n");
                        Console.WriteLine("\nPressione 'Enter' para voltar.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (saida != 1);
        }
        static void Linha()
        {
            Console.WriteLine("-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+=-=+");
        }
        public static double adicao(double n1, double n2)
        {
            double resultado = n1 + n2;
            return resultado;
        }
        public static double subitracao(double n1, double n2)
        {
            double resultado = n1 - n2;
            return resultado;
        }
        public static double divicao(double n1, double n2)
        {
            double resultado = n1 / n2;
            return resultado;
        }
        public static double mutiplicacao(double n1, double n2)
        {
            double resultado = n1 * n2;
            return resultado;
        }
    }
}