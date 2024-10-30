using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quests_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu Quests\n");
                Console.WriteLine("{0} - Sair");
                Console.WriteLine("{1} - Questão 1");
                Console.WriteLine("{2} - Questão 2");
                Console.WriteLine("{3} - Questão 3");
                Console.WriteLine("{4} - Questão 4");
                Console.WriteLine("{5} - Questão 5");
                Console.WriteLine("{6} - Questão 6");
                Console.WriteLine("{7} - Questão 7");
                Console.WriteLine("{8} - Questão 8");
                Console.WriteLine("{9} - Questão 9");
                Console.WriteLine("{10} - Questão 10");
                Console.WriteLine("{11} - Questão 11");
                Console.WriteLine("{12} - Questão 12");
                Console.WriteLine("{13} - Questão 13");
                Console.WriteLine("{14} - Questão 14");
                Console.WriteLine("{15} - Questão 15");
                Console.WriteLine("{16} - Questão 16");
                Console.WriteLine("{17} - Questão 17");
                Console.WriteLine("{18} - Questão 18");
                Console.WriteLine("{19} - Questão 19");
                Console.WriteLine("{20} - Questão 20");
                Console.WriteLine("{21} - Questão 21");
                Console.WriteLine("{22} - Questão 22");
                Console.WriteLine("{23} - Questão 23");
                Console.WriteLine("{24} - Questão 24");
                Console.WriteLine("{25} - Questão 25");
                Console.WriteLine("{26} - Questão 26");
                Console.WriteLine("{27} - Questão 27");
                Console.WriteLine("{28} - Questão 28");
                Console.WriteLine("{29} - Questão 29");
                Console.WriteLine("{30} - Questão 30");
                Console.WriteLine("{31} - Questão 31");
                Console.WriteLine("{32} - Questão 32");
                Console.WriteLine("{33} - Questão 33");
                Console.WriteLine("{34} - Questão 34");
                Console.WriteLine("{35} - Questão 35");
                Console.WriteLine("{36} - Questão 36");
                Console.WriteLine("{37} - Questão 37");
                Console.WriteLine("{38} - Questão 38");
                Console.WriteLine("{39} - Questão 39");
                Console.WriteLine("{40} - Questão 40");
                Console.WriteLine("{41} - Questão 41");
                Console.WriteLine("{42} - Questão 42");
                Console.WriteLine("{43} - Questão 43");
                Console.WriteLine("{44} - Questão 44");
                Console.WriteLine("{45} - Questão 45");
                Console.WriteLine("{46} - Questão 46");
                Console.WriteLine("{47} - Questão 47");
                Console.WriteLine("{48} - Questão 48");
                Console.WriteLine("{49} - Questão 49");
                Console.WriteLine("{50} - Questão 50");
                Console.WriteLine("{51} - Questão 51");
                Console.WriteLine("{52} - Questão 53");
                Console.WriteLine("{53} - Questão 53");
                Console.WriteLine("{54} - Questão 54");
                Console.WriteLine("{55} - Questão 55");
                Console.WriteLine("{56} - Questão 56");
                Console.WriteLine("{57} - Questão 57");
                Console.WriteLine("{58} - Questão 58");
                Console.WriteLine("{59} - Questão 59");
                Console.WriteLine("{60} - Questão 60");
                Console.WriteLine("{61} - Questão 61");
                Console.WriteLine("{62} - Questão 62");
                Console.WriteLine("{63} - Questão 63");
                Console.WriteLine("{64} - Questão 64");
                Console.WriteLine("{65} - Questão 65");
                Console.WriteLine("{66} - Questão 66");
                Console.WriteLine("{67} - Questão 67");
                Console.WriteLine("{68} - Questão 68");
                Console.WriteLine("{69} - Questão 69");
                Console.WriteLine("{70} - Questão 70");
                Console.WriteLine("{71} - Questão 71");
                Console.WriteLine("{72} - Questão 72");
                Console.WriteLine("{73} - Questão 73");
                Console.WriteLine("{74} - Questão 74");
                Console.WriteLine("{75} - Questão 75");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1: 
                        Console.Clear(); 
                        Quests.Q1Q2(); Console.ReadKey(); 
                        break;
                    case 2: 
                        Console.Clear(); 
                        Quests.Q1Q2(); 
                        Console.ReadKey(); 
                        break;
                    case 3: 
                        Console.Clear();
                        Quests.Q3(5, 6); 
                        Console.ReadKey(); 
                        break;
                    case 4: 
                        Console.Clear();
                        Quests.Q4(5); 
                        Console.ReadKey(); 
                        break;
                    case 5: 
                        Console.Clear();
                        Quests.Q5(9); 
                        Console.ReadKey(); 
                        break;
                    case 6: 
                        Console.Clear();
                        Quests.Q6(22); 
                        Console.ReadKey(); 
                        break;
                    case 7: 
                        Console.Clear();
                        Quests.Q7(6); 
                        Console.ReadKey(); 
                        break;
                    case 8: 
                        Console.Clear();
                        Quests.Q8(6); 
                        Console.ReadKey(); 
                        break;
                    case 9: 
                        Console.Clear();
                        Quests.Q9(10); 
                        Console.ReadKey(); 
                        break;
                    case 10: 
                        Console.Clear();
                        Quests.Q10((float)1.8); 
                        Console.ReadKey(); 
                        break;
                    case 11: 
                        Console.Clear();
                        Quests.Q11(" "); 
                        Console.ReadKey(); 
                        break;
                    case 12: 
                        Console.Clear();
                        Quests.Q12(); 
                        Console.ReadKey(); 
                        break;
                    case 13: 
                        Console.Clear();
                        Quests.Q13(4, 6, 20); 
                        Console.ReadKey(); 
                        break;
                    case 14: 
                        Console.Clear();
                        Quests.Q14("Bicicleta"); 
                        Console.ReadKey(); 
                        break;
                    case 15: 
                        Console.Clear();
                        Quests.Q15(27, 11, 2002); 
                        Console.ReadKey(); 
                        break;
                    case 16: 
                        Console.Clear();
                        Quests.Q16(-68); 
                        Console.ReadKey(); 
                        break;
                    case 17: 
                        Console.Clear();
                        Quests.Q17(5, 5, 10); 
                        Console.ReadKey(); 
                        break;
                    case 18: 
                        Console.Clear();
                        Quests.Q18("Aliaa"); 
                        Console.ReadKey(); 
                        break;
                    case 19: 
                        Console.Clear();
                        Quests.Q19(); 
                        Console.ReadKey(); 
                        break;
                    case 20: 
                        Console.Clear();
                        Quests.Q20(5); 
                        Console.ReadKey(); 
                        break;
                    case 21: 
                        Console.Clear();
                        Quests.Q21("Izy", 20); 
                        Console.ReadKey(); 
                        break;
                    case 22: 
                        Console.Clear();
                        Quests.Q22(32); 
                        Console.ReadKey(); 
                        break;
                    case 23: 
                        Console.Clear();
                        Quests.Q23("Hanna"); 
                        Console.ReadKey(); 
                        break;
                    case 24: 
                        Console.Clear();
                        Quests.Q24(8); 
                        Console.ReadKey(); 
                        break;
                    case 25: 
                        Console.Clear();
                        Quests.Q25(10); 
                        Console.ReadKey(); 
                        break;
                    case 26: 
                        Console.Clear();
                        Quests.Q26(4, 3, 8); 
                        Console.ReadKey(); 
                        break;
                    case 27: 
                        Console.Clear();
                        Quests.Q27(7); 
                        Console.ReadKey(); 
                        break;
                    case 28: 
                        Console.Clear();
                        Quests.Q28(); 
                        Console.ReadKey(); 
                        break;
                    case 29: 
                        Console.Clear();
                        Quests.Q29(new List<double> { 3, 8, 7 }); 
                        Console.ReadKey(); 
                        break;
                    case 30: 
                        Console.Clear();
                        Quests.Q30("Fernando"); 
                        Console.ReadKey(); 
                        break;
                    case 31:
                        int[] ar = { 3, 42, 4, 11, 99};
                        Console.Clear();
                        Quests.Q31(ar);
                        Console.ReadKey(); 
                        break;
                    case 32:
                        int[] ar32 = { 3, 9, 55, 35, 72 };
                        Console.Clear();
                        Quests.Q32(ar32, 5);
                        Console.ReadKey(); 
                        break;
                    case 33:
                        int[] ar33 = { 3, 4, 6, 24, 54 };
                        Console.Clear();
                        Quests.Q33(ar33);
                        Console.ReadKey(); 
                        break;
                    case 34: 
                        Console.Clear();
                        Quests.Q34(); 
                        Console.ReadKey(); 
                        break;
                    case 35: 
                        Console.Clear();
                        Quests.Q35(2006); 
                        Console.ReadKey(); 
                        break;
                    case 36:
                        int q = 9;
                        Console.Clear();
                        Quests.Q36(q);
                        Console.ReadKey(); 
                        break;
                    case 37:
                        string f = "Júlio Oliveira dos Santos";
                        Console.Clear();
                        Quests.Q37(f);
                        Console.ReadKey(); 
                        break;
                    case 38:
                        int[] ar38 = { 5, 2, 5, 9, 2 };
                        Console.Clear();
                        Quests.Q38(ar38); 
                        Console.ReadKey(); 
                        break;
                    case 39:
                        int numb1 = 3;
                        int numb2 = 7;
                        Console.Clear();
                        Quests.Q39(numb1, numb2);
                        Console.ReadKey(); 
                        break;
                    case 40:
                        string xab = "Paranaue";
                        Console.Clear();
                        Quests.Q40(xab);
                        Console.ReadKey(); 
                        break;
                    case 41:
                        int dec = 50;
                        Console.Clear();
                        Quests.Q41(dec);
                        Console.ReadKey(); 
                        break;
                    case 42: 
                        Console.Clear();
                        Quests.Q42(10); 
                        Console.ReadKey(); 
                        break;
                    case 43: 
                        Console.Clear();
                        Quests.Q43(3); 
                        Console.ReadKey(); 
                        break;
                    case 44: 
                        Console.Clear();
                        Quests.Q44(67, 1.70); 
                        Console.ReadKey(); 
                        break;
                    case 45:
                        Console.Clear();
                        Quests.Q45(new int[] { 3, 7, 8, 10, 22 });
                        Console.ReadKey(); 
                        break;
                    case 46:
                        Console.Clear();
                        Quests.Q46(new int[] { 3, 7, 8, 10, 22 });
                        Console.ReadKey(); 
                        break;
                    case 47:
                        int[,] m1 = { { 7, 3 }, { 3, 8 } };
                        int[,] m2 = { { 1, 0 }, { 2, 5 } };
                        Console.Clear();
                        Quests.Q47(m1, m2);
                        Console.ReadKey(); 
                        break;
                    case 48: Console.Clear();
                        Quests.Q48(); 
                        Console.ReadKey(); 
                        break;
                    case 49: 
                        Console.Clear();
                        Quests.Q49("Gabriel"); 
                        Console.ReadKey(); 
                        break;
                    case 50: 
                        Console.Clear();
                        Quests.Q50(3, 2); 
                        Console.ReadKey(); 
                        break;
                    case 51:
                        int[,] symmMatrix = { { 7, -3, 4 }, { -3, 8, 2 }, { 4, 2, 5 } };
                        int[,] nonsymmMatrix = { { 1, 0, 3 }, { 2, 5, 6 }, { 7, 8, 4 } };
                        Console.Clear();
                        Quests.Q51(symmMatrix);
                        Console.Clear();
                        Quests.Q51(nonsymmMatrix);
                        Console.ReadKey(); 
                        break;
                    case 52:
                        List<string> l = new List<string> { "Alex", "Lilas", "Junio", "Marcelo", "João", "Ana" };
                        Console.Clear();
                        Quests.Q52(l);
                        Console.ReadKey(); 
                        break;
                    case 53:
                        int[] arrayF = { 6, 9, 2, 3, 6, 3, 6, 6, 1 };
                        Console.Clear();
                        Quests.Q53(arrayF);
                        Console.ReadKey(); 
                        break;
                    case 54:
                        Console.Clear();
                        Quests.Q54(-10);
                        Console.ReadKey(); 
                        break;
                    case 55:
                        int[] arrayL = { 6, 9, 8, 4, 3, 1 };
                        Console.Clear();
                        Quests.Q55(arrayL, 1);
                        Console.ReadKey(); 
                        break;
                    case 56:
                        Console.Clear();
                        Quests.Q56();
                        Console.ReadKey(); 
                        break;
                    case 57:
                        Console.Clear();
                        Quests.Q57("Yep");
                        Console.ReadKey(); 
                        break;
                    case 58:
                        Console.Clear();
                        Quests.Q58();
                        Console.ReadKey(); 
                        break;
                    case 59:
                        int[] array1 = { 1, 2, 3, 4, 5 };
                        int[] array2 = { 4, 5, 6, 7, 8 };
                        Console.Clear();
                        Quests.Q59(array1, array2);
                        Console.ReadKey(); 
                        break;
              
                    case 60:
                        Console.WriteLine("Digite uma palavra: \n");
                        string palavra60 = Console.ReadLine();
                        string Alternado = Quests.Alternar_Maiuscula_Minuscula(palavra60);
                        Console.Clear();
                        Console.WriteLine($"Palavra alternada entre Maiúsculo e minúsculo: {Alternado}");
                        Console.ReadKey();
                        break;

                    case 61:
                        Console.WriteLine("Digite uma palavra: \n");
                        string palavra61 = Console.ReadLine();
                        int ContarCharUnicos = Quests.Contar_Caracteres_Unicos(palavra61);
                        Console.Clear();
                        Console.WriteLine($"Número de caracteres únicos: {ContarCharUnicos}");
                        Console.ReadKey();
                        break;

                    case 62:
                        Console.WriteLine("Digite um número limite: \n");
                        int limite = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Números primos: \n");
                        Quests.Numeros_Primos(limite);
                        Console.ReadKey();
                        break;

                    case 63:
                        Console.WriteLine("Digite um número: \n");
                        int num63 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (Quests.Numero_Perfeito(num63))
                        {
                            Console.WriteLine($"{num63} é um número perfeito!");
                        }
                        else
                        {
                            Console.WriteLine($"{num63} não é um número perfeito!");
                        }
                        Console.ReadKey();
                        break;

                    case 64:
                        Console.WriteLine("Digite um número: \n");
                        int num64 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"Divisores de {num64}: \n");
                        Quests.Divisores(num64);
                        Console.ReadKey();
                        break;

                    case 65:
                        Quests.Calcular_Transposta();

                        break;

                    case 66:
                        Quests.Horario();
                        break;

                    case 67:
                        Quests.Calculadora();
                        break;

                    case 68:
                        Console.WriteLine("Digite o valor que será convertido: ");
                        double valor = double.Parse(Console.ReadLine());
                        Console.Clear();
                        string valorExtenso = Quests.Valor_Extenso(valor);
                        Console.WriteLine($"Valor por extenso: {valorExtenso}");
                        Console.ReadKey();
                        break;

                    case 69:
                        Quests.Media_Ponderada();
                        break;

                    case 70:
                        Quests.Caixa();
                        break;

                    case 71:
                        Console.WriteLine("Quantos itens terá no primeiro array?");
                        int tam1 = int.Parse(Console.ReadLine());
                        int[] array71 = new int[tam1];
                        Console.Clear();

                        for (int i = 0; i < tam1; i+=1)
                        {
                            Console.Write($"Digite o elemento {i + 1} do primeiro array: ");
                            array71[i] = int.Parse(Console.ReadLine());
                        }
                        Console.Clear();

                        Console.WriteLine("Quantos itens terá no segundo array?");
                        int tam2 = int.Parse(Console.ReadLine());
                        int[] array72 = new int[tam2];
                        Console.Clear();

                        for (int i = 0; i < tam2; i+=1)
                        {
                            Console.Write($"Digite o elemento {i + 1} do segundo array: ");
                            array72[i] = int.Parse(Console.ReadLine());
                        }
                        Console.Clear();

                        bool comparar = Quests.Comparar_Arrays(array71, array72);
                        Console.WriteLine($"Os arrays são iguais? {comparar}");
                        Console.ReadKey();

                        break;

                    case 72:
                        Console.Write("Digite o tamanho da senha: ");
                        int tam = int.Parse(Console.ReadLine());
                        string senhaAleatoria = Quests.Senha_Aleatoria(tam);
                        Console.Clear();
                        Console.WriteLine($"Senha aleatória: {senhaAleatoria}");
                        Console.ReadKey();
                        break;

                    case 73:
                        Quests.Tabela_Multiplicacao();
                        break;

                    case 74:
                        Console.WriteLine("Digite o primeiro lado do triângulo:");
                        double lado1 = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("Digite o segundo lado do triângulo:");
                        double lado2 = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("Digite o terceiro lado do triângulo:");
                        double lado3 = double.Parse(Console.ReadLine());
                        Console.Clear();

                        double area = Quests.Calcular_Area_Triangulo(lado1, lado2, lado3);
                        Console.WriteLine($"A área do triângulo é: {area}");
                        Console.ReadKey();
                        break;

                    case 75:
                        Console.Write("Digite a quantidade de números: ");
                        int num = int.Parse(Console.ReadLine());
                        Console.Clear();

                        List<int> numerosAleatorios = Quests.Numeros_Aleatorios_Unicos(num);

                        Console.WriteLine("Números aleatórios únicos:");
                        foreach (int numero in numerosAleatorios)
                        {
                            Console.WriteLine(numero);
                        }
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 0);
        }
    }
}
