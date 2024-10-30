using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ProjetoQuestoesCSharp;

namespace Quests_POO
{
    internal class Quests
    {
        //1 e 2
        public static void Q1Q2()
        {
            product prod = new product("Arroz", 32.00f);
            Console.WriteLine($"Produto: {prod.Name} - R${prod.Price}.\n");
        }

        //3
        public static void Q3(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"A soma é: {sum}\n");
        }

        //4 
        public static void Q4(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine($"O número {n} é par\n");
            }
            else
            {
                Console.WriteLine($"O número {n} é ímpar\n");
            }
        }

        //5  
       public static void Q5(int m)
        {
            int cm = m * 100;
            Console.WriteLine($"{m}M são {cm}cm\n");
        }

        //6  
        public static void Q6(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"A idade {age} é maioridade\n");
            }
            else
            {
                Console.WriteLine($"A idade {age} é menoridade\n");
            }
        }

        //7
        public static void Q7(int r)
        {
            float pi = 3.14f;
            var area = pi * (r * r);
            Console.WriteLine($"O é raio {r}, a area do circulo é {area}\n");
        }

        //8  
        public static void Q8(int n)
        {
            Console.WriteLine($"[Tabela de multiplicação.]\n");
            for (global::System.Int32 i = 0; i < 11; i++)
            {
                int multip = n * i;
                Console.WriteLine($"{n} X {i} = {multip}\n");
            }
        }

        //9  
        public static void Q9(int N)
        {
            Console.WriteLine($"[Tabela de soma.]\n");
            for (global::System.Int32 i = 1; i < N + 1; i++)
            {
                int sumN = i + N;
                Console.WriteLine($"{i} + {N} = {sumN}\n");
            }
        }

        //10  
        public static void Q10(float C)
        {
            float F = C * 3.3f + 32f;
            Console.WriteLine($"{C} celsius são {F} fahrenheit.\n");
        }

        //11  
        public static void Q11(string s)
        {
            if (string.IsNullOrEmpty(s.Trim()))
            {
                Console.WriteLine($"a string é vazia.\n");
            }
            else
            {
                Console.WriteLine($"a string não é vazia.\n");
            }
        }

        //12  
        public static void Q12()
        {
            for (global::System.Int32 i = 1; i < 51; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }

        //13  
        public static void Q13(int a, int b, int c)
        {
            var bigger = Math.Max(a, Math.Max(b, c));
            Console.WriteLine($"\nO maior número é: {bigger}\n");
        }

        //14
        public static void Q14(string s)
        {
            char[] cArray = s.ToCharArray();
            Array.Reverse(cArray);
            string invertedString = new string(cArray);
            Console.WriteLine($"String invertida: {invertedString}\n");
        }

        //15  
        public static void Q15(int day, int month, int year)
        {
            if (year < 2007 && month < 11)
            {
                Console.WriteLine($"Nascido em: {year} - Apto para votar\n");
            }
            else
            {
                Console.WriteLine($"Nascido em: {month} - Inapto para votar\n");
            }
        }

        //16  
        public static void Q16(double numb)
        {
            if (numb < 0)
            {
                Console.WriteLine($"[{numb}] -> negativo\n");
            }
            else
            {
                Console.WriteLine($"[{numb}] -> positivo\n");
            }
        }

        //17  
        public static void Q17(int sco1, int sco2, int sco3)
        {
            int media = (sco1 + sco2 + sco3) / 3;
            if (media < 7)
            {
                Console.WriteLine($"média final: {media} / reprovado\n");
            }
            else
            {
                Console.WriteLine($"média final: {media} / aprovado\n");
            }
        }

        //18  
        public static void Q18(string s)
        {
            int count = 0;

            foreach (char c in s.ToLower())
            {
                if (c == 'a')
                {
                    count++;
                }
            }
            Console.WriteLine($"a palavra {s} possui {count} de 'a'\n");
        }

        //19  
        public static void Q19()
        {
            for (global::System.Int32 i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        //20  
        public static void Q20(int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i * i;
            }
            Console.WriteLine($"\nsoma dos quadrados de 1 até {N} = {sum}\n");
        }

        //21  
        public static void Q21(string name, int age)
        {
            Console.WriteLine($"Seja bem-vindo(a), {name} de {age} anos!\n");
        }

        //22  
        public static void Q22(int numb)
        {
            double doub = numb * 2;
            double triple = numb * 3;
            Console.WriteLine($"{numb} - dobro: {doub} // triplo: {triple}\n");
        }

        //23  
        public static void Q23(string s)
        {
            var last = s[s.Length - 1];
            Console.WriteLine($"Último caractere de {s} é {last}\n");
        }

        //24  
        public static void Q24(int hours)
        {
            int converter = hours * 3600;
            Console.WriteLine($"{hours} horas são {converter} segundos\n");
        }

        //25  
        public static void Q25(int numb)
        {
            if (numb % 3 == 0 && numb % 5 == 0)
            {
                Console.WriteLine($"{numb} é divisivel por 3 e 5!\n");
            }
            else
            {
                Console.WriteLine($"{numb} não é divisivel por 3 e 5!\n");
            }

        }

        //26  
        public static void Q26(int n1, int n2, int n3)
        {
            int menor, medio, maior;

            if (n1 <= n2 && n1 <= n3)
            {
                menor = n1;
                if (n2 <= n3)
                {
                    medio = n2;
                    maior = n3;
                }
                else
                {
                    medio = n3;
                    maior = n2;
                }
            }
            else if (n2 <= n1 && n2 <= n3)
            {
                menor = n2;
                if (n1 <= n3)
                {
                    medio = n1;
                    maior = n3;
                }
                else
                {
                    medio = n3;
                    maior = n1;
                }
            }
            else
            {
                menor = n3;
                if (n1 <= n2)
                {
                    medio = n1;
                    maior = n2;
                }
                else
                {
                    medio = n2;
                    maior = n1;
                }
            }
            Console.WriteLine($"Números em ordem crescente: {menor}, {medio}, {maior}\n");
        }

        //27  
        public static void Q27(int numb)
        {
            int fatorial = 1;
            for (global::System.Int32 i = numb; i > 0; i--)
            {
                fatorial *= i;
            }
            Console.WriteLine($"fatorial de {numb} = {fatorial}\n");
        }

        //28
        public static void Q28()
        {
            Aluno aluno = new Aluno("Gabriel", 7.6f);
            Console.WriteLine($"Nome aluno: {aluno.Name} - Nota: {aluno.Grade}.\n");
        }

        //29
        public static void Q29(List<double> numb)
        {
            List<double> list = new List<double> { 9, 8, 9 };
            double sum = numb.Sum();
            double avarage = sum / numb.Count;
            Console.WriteLine($"a média da lista é: {avarage:F2}\n");

        }

        //30
        public static void Q30(string s)
        {
            s = s.ToLower();

            int start = 0;
            int end = s.Length - 1;
            bool isPalindromo = true;

            while (start < end)
            {
                if (s[start] != s[end])
                {
                    isPalindromo = false;
                    break;
                }
                start++;
                end--;
            }
            if (isPalindromo)
            {
                Console.WriteLine($"{s} é palíndromo\n");
            }
            else
            {
                Console.WriteLine($"{s} não é palíndromo\n");
            }
        }

        //31
        public static void Q31(int[] array)
        {
            int smallest = array[0];

            foreach (int number in array)
            {
                if (number < smallest)
                {
                    smallest = number;
                }
            }
            Console.WriteLine($"O menor número de [{string.Join(", ", array)}] é {smallest}\n");
        }

        //32
        public static void Q32(int[] array, int numb)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i] * numb;
            }

            Console.WriteLine($"Array: [{string.Join(", ", array)}] // Array após multiplicar por {numb}: [{string.Join(", ", newArray)}]\n");
        }

        //33
        public static void Q33(int[] array)
        {
            int sum = 0;

            foreach (int number in array)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine($"Soma dos números ímpares: {sum}\n");
        }

        //34
        public static void Q34()
        {
            Carro carro = new Carro("Civic Type R", "Honda", 2024);
            Console.WriteLine($"Carro: {carro.Name} - marca: {carro.Label} - ano: {carro.Year}\n");
        }

        //35
        public static void Q35(int year)
        {

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} é bissexto\n");
            }
            else
            {
                Console.WriteLine($"{year} não é bissexto\n");
            }

        }

        //36
        public static void Q36(int qtd)
        {
            int aux = 1, aux2 = 1, next;

            if (qtd == 0)
            {
                Console.WriteLine("A quantidade de termos deve ser maior que 0.\n");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            Console.Clear();

            Console.Write($"A sequência de Fibonacci equivalente ao termo {qtd} é: {aux}\n");

            for (int i = 2; i < qtd + 1; i++)
            {
                next = aux + aux2;
                aux = aux2;
                aux2 = next;
                Console.Write($", {aux}\n");
            }
        }

        //37
        public static void Q37(string s)
        {
            s = s.Replace(" ", "_");
            Console.Clear();
            Console.WriteLine($"{s}\n");
        }

        //38
        public static void Q38(int[] nums)
        {
            int biggest = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > nums[biggest])
                {
                    biggest = i;
                }
            }

            Console.WriteLine($"{biggest}\n");
        }

        //39
        public static void Q39(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 -= num2;
                }
                else
                {
                    num2 -= num1;
                }
            }

            Console.Write($"MDC: {num1}\n");
        }

        //40
        public static void Q40(string toshow)
        {
            string tocheck = toshow.ToLower();

            int count = 0;
            foreach (char c in tocheck)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                }
            }
            Console.Clear();
            Console.Write($"A string '{toshow}' contém {count} vogais\n");
        }

        //41
        public static void Q41(int num)
        {
            Console.Write($"O número {num} em binário é: {Convert.ToString(num, 2)}\n");
        }

        //42
        public static void Q42(int num)
        {
            char letra = (char)('A' + num - 1);
            Console.Write($"O número {num} em caractere é: {letra}\n");
        }

        //43
        public static void Q43(int qty)
        {
            Random random = new Random();
            int num = random.Next(1, 7);

            int[] frequency = new int[6];

            for (int i = 0; i < 1000; i++)
            {
                num = random.Next(1, 7);
                frequency[num - 1]++;
            }

            Console.Clear();
            Console.WriteLine($"Resultado dos {qty} lançamentos:");
            for (int i = 0; i < frequency.Length; i++)
            {
                Console.WriteLine($"Lado {i + 1}: {frequency[i]} vezes\n");
            }
        }

        //44
        public static void Q44(double Weight, double Height)
        {
            double imc = Weight / Math.Pow(Height, 2);

            var classifyIMC = new Dictionary<string, (double Min, double Max)>
        {
            { "Abaixo do peso", (0.0, 18.5) },
            { "Peso normal", (18.51, 24.9) },
            { "Sobrepeso", (25.0, 29.9) },
            { "Obesidade Grau I", (30.0, 34.9) },
            { "Obesidade Grau II", (35.0, 39.9) },
            { "Obesidade Grau III", (40.0, double.MaxValue) }
        };

            string classification = "";
            foreach (var item in classifyIMC)
            {
                if (imc >= item.Value.Min && imc <= item.Value.Max)
                {
                    classification = item.Key;
                    break;
                }
            }

            Console.WriteLine($"\nIMC: {imc:F2}\n");
            Console.WriteLine($"Classificação: {classification}\n");
        }

        //45
        public static void Q45(int[] nums)
        {
            int biggest = int.MinValue;
            int second = int.MinValue;

            foreach (int num in nums)
            {
                if (num > biggest)
                {
                    second = biggest;
                    biggest = num;
                }
                else if (num > second && num != biggest)
                {
                    second = num;
                }
            }

            Console.WriteLine($"O segundo maior número é: {second}\n");
        }

        //46
        public static void Q46(int[] nums)
        {
            int[] Before = (int[])nums.Clone();
            Array.Reverse(nums);

            Console.WriteLine($"Antes da inversão: {string.Join(", ", Before)}");
            Console.WriteLine($"Depois da inversão: {string.Join(", ", nums)}");
        }

        //47
        public static void Q47(int[,] matrixA, int[,] matrixB)
        {
            if (matrixA.GetLength(0) != 2 || matrixA.GetLength(1) != 2 || matrixB.GetLength(0) != 2 || matrixB.GetLength(1) != 2)
            {
                Console.WriteLine("Ambas as matrizes devem ser 2x2!\n");
                return;
            }

            int[,] result = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            Console.WriteLine("\nMatriz resultante:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{result[i, j],4} ");
                }
                Console.WriteLine();
            }
        }

        //48
        public static void Q48()
        {
            Console.Write("Digite uma data (formato: dd/MM/yyyy): \n");
            string input = Console.ReadLine();
            Console.Clear();

            if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime data))
            {
                var daysOfWeek = new Dictionary<DayOfWeek, string>
            {
                { DayOfWeek.Sunday, "Domingo" },
                { DayOfWeek.Monday, "Segunda-feira" },
                { DayOfWeek.Tuesday, "Terça-feira" },
                { DayOfWeek.Wednesday, "Quarta-feira" },
                { DayOfWeek.Thursday, "Quinta-feira" },
                { DayOfWeek.Friday, "Sexta-feira" },
                { DayOfWeek.Saturday, "Sábado" }
            };

                string dayInPTBR = daysOfWeek[data.DayOfWeek];
                Console.WriteLine($"Dia da semana: {dayInPTBR}\n");
            }
            else
            {
                Console.WriteLine("Data inválida. Por favor, utilize o formato dd/MM/yyyy.\n");
            }
        }

        //49
        public static void Q49(string input)
        {
            bool OnlyLettersOrNums(string str)
            {
                foreach (char c in str)
                {
                    if (!char.IsLetterOrDigit(c) && c != ' ')
                    {
                        return false;
                    }
                }
                return true;
            }

            var message = OnlyLettersOrNums(input) ? "\nA string contém apenas letras ou números\n" : "\nA string contém outros tipos de caracteres\n";

            Console.WriteLine(message);
        }

        //50
        public static void Q50(double numb, int exponent)
        {
            double result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= numb;
            }
            Console.WriteLine($"Potência de {numb} elevado a {exponent} é {result}\n");
        }

        //51
        public static void Q51(int[,] m)
        {
            int rows = m.GetLength(0);
            int cols = m.GetLength(1);

            if (rows != cols)
            {
                Console.WriteLine("A matriz não é simétrica\n");
                return;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = i + 1; j < cols; j++)
                {
                    if (m[i, j] != m[j, i])
                    {
                        Console.WriteLine("A matriz não é simétrica\n");
                        return;
                    }
                }
            }

            Console.WriteLine("A matriz é simétrica\n");
        }

        //52
        public static void Q52(List<string> list)
        {
            list.Sort();
            Console.WriteLine("[Lista em ordem alfabetica:]");
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }
        }

        //53
        public static void Q53(int[] array)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            int count = 0;
            int e = array[0];

            foreach (var num in array)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }

                if (frequency[num] > count)
                {
                    count = frequency[num];
                    e = num;
                }
            }

            Console.WriteLine($"\nO elemento mais frequente é: {e}.\n");
        }

        //54
        public static void Q54(double numb)
        {
            double value = (numb < 0) ? -numb : numb;
            Console.WriteLine($"O valor absoluto de {numb} é: {value}\n");
        }

        //55
        public static void Q55(int[] array, int e)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == e)
                {
                    Console.WriteLine($"Elemento {e} encontrado no índice {i}.\n");
                    return;
                }
            }
            Console.WriteLine($"Elemento {e} não encontrado no array.\n");
        }

        //56
        public static void Q56()
        {
            Console.WriteLine("[Cronômetro iniciado. Aperte qualquer tecla para parar!]");

            int seconds = 0;
            while (!Console.KeyAvailable)
            {
                Console.Clear();
                Console.WriteLine($"Cronômetro: {seconds}s");
                Thread.Sleep(800);
                seconds++;
            }

            Console.ReadKey(true);
            Console.WriteLine($"Cronômetro marcou {seconds}s.");
        }

        public static void Q57(string s)
        {
            string[] words = s.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            Console.WriteLine($"Numero de palavras na frase {s}: {wordCount}\n");
        }

        //58
        public static void Q58()
        {
            Console.WriteLine($"Escreva uma mensagem:\n");
            string m = Console.ReadLine();
            Pessoa pessoa = new Pessoa(m);
            Console.WriteLine($"Mensagem: {pessoa.Talk}\n");
        }

        //59
        public static void Q59(int[] array1, int[] array2)
        {
            HashSet<int> set = new HashSet<int>(array1);
            List<int> intersection = new List<int>();

            foreach (int num in array2)
            {
                if (set.Contains(num))
                {
                    intersection.Add(num);
                }
            }

            Console.WriteLine("Interseção entre os arrays: " + string.Join(", ", intersection));
        }


        //60
        public static string Alternar_Maiuscula_Minuscula(string palavra60)
        {
            char[] character = palavra60.ToCharArray();

            for (int i = 0; i < character.Length; i += 1)
            {
                if (i % 2 == 0)
                {
                    character[i] = char.ToUpper(character[i]);
                }
                else
                {
                    character[i] = char.ToLower(character[i]);
                }
            }
            return new string(character);
        }

        //61
        public static int Contar_Caracteres_Unicos(string palavra61)
        {
            HashSet<char> caracteresUnicos = new HashSet<char>();

            foreach (char charUni in palavra61)
            {
                caracteresUnicos.Add(charUni);
            }

            return caracteresUnicos.Count;
        }

        //62
        public static void Numeros_Primos(int limite)
        {
            for (int num = 2; num <= limite; num += 1)
            {
                bool Primo = true;

                for (int i = 2; i <= Math.Sqrt(num); i += 1)
                {
                    if (num % i == 0)
                    {
                        Primo = false;
                        break;
                    }
                }
                if (Primo)
                {
                    Console.WriteLine(num);
                }
            }
        }

        //63
        public static bool Numero_Perfeito(int num63)
        {
            int soma = 0;

            for (int i = 1; i < num63; i += 1)
            {
                if (num63 % i == 0)
                {
                    soma += i;
                }
            }

            return soma == num63;
        }

        //64
        public static void Divisores(int num64)
        {
            for (int i = 1; i <= num64; i += 1)
            {
                if (num64 % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //65
        public static void Calcular_Transposta()
        {
            int[,] matriz = {
            {11, 12, 13},
            {14, 15, 16},
            {17, 18, 19}
                       };

            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            int[,] transposta = new int[colunas, linhas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    transposta[j, i] = matriz[i, j];
                }
            }

            Console.WriteLine("Matriz transposta:");
            for (int i = 0; i < colunas; i++)
            {
                for (int j = 0; j < linhas; j++)
                {
                    Console.Write($"{transposta[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        //66
        public static void Horario()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Horário atual: \n");
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                Console.WriteLine("\n{0} - Sair");

                if (Console.KeyAvailable)
                {
                    if (int.TryParse(Console.ReadLine(), out int numero) && numero == 0)
                    {
                        break;
                    }
                }
                Thread.Sleep(1000);
            }
        }

        //67
        public static void Calculadora()
        {
            int num67;
            int nume67;
            int op = -1;

            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Calculadora\n");
                Console.WriteLine("{1} - Soma");
                Console.WriteLine("{2} - Subtração");
                Console.WriteLine("{3} - Multiplicação");
                Console.WriteLine("{4} - Divisão");
                Console.WriteLine("{0} - Sair");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite o primeiro número para somar: ");
                        num67 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Digite o segundo número para somar: ");
                        nume67 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"O resultado da soma é: {num67 + nume67}");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Digite o primeiro número para subtrair: ");
                        num67 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Digite o segundo número para subtrair: ");
                        nume67 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"O resultado da subtração é: {num67 - nume67}");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Digite o primeiro número para multiplicar: ");
                        num67 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Digite o segundo número para multiplicar: ");
                        nume67 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (nume67 == 0)
                        {
                            Console.WriteLine("O resultado da multiplicação é: 0");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine($"O resultado da multiplicação é: {num67 * nume67}");
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        Console.WriteLine("Digite o primeiro número para dividir: ");
                        num67 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Digite o segundo número para dividir: ");
                        nume67 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (nume67 == 0)
                        {
                            Console.WriteLine("Não é possível dividir por 0!");
                            Console.ReadKey();
                        }
                        else
                        {
                            double divisao1 = (double)num67;
                            double divisao2 = (double)nume67;
                            double resultado = divisao1 / divisao2;
                            Console.WriteLine($"O resultado da divisão é: {resultado}");
                            Console.ReadKey();
                        }
                        break;

                    case 0:
                        break;
                }
            }
        }

        //68
        public static string Numero_Extenso(int num68)
        {
            string[] unid = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
            string[] deze = { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            string[] espec = { "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string extenso = "";

            if (num68 < 10)
            {
                extenso = unid[num68];
            }
            else if (num68 < 20)
            {
                extenso = espec[num68 - 10];
            }
            else if (num68 < 100)
            {
                extenso = deze[num68 / 10];
                if (num68 % 10 > 0)
                {
                    extenso += " e " + unid[num68 % 10];
                }
            }
            else if (num68 < 1000)
            {
                extenso = unid[num68 / 100] + " cento";
                int resto = num68 % 100;
                if (resto > 0)
                {
                    extenso += " e " + Numero_Extenso(resto);
                }
            }

            return extenso;
        }
        public static string Valor_Extenso(double dinheiro)
        {
            int valorInteiro = (int)dinheiro;
            int centavos = (int)((dinheiro - valorInteiro)) * 100;


            string extenso = Numero_Extenso(valorInteiro) + " reais";
            if (centavos > 0)
            {
                extenso += " e " + Numero_Extenso(centavos) + " centavos";
            }

            return extenso;
        }

        //69
        public static void Media_Ponderada()
        {
            Console.WriteLine("Quantas notas você serão inseridas?");
            int quant = int.Parse(Console.ReadLine());
            Console.Clear();

            double[] notas = new double[quant];
            double[] pesos = new double[quant];
            double somaPesos = 0;
            double somaPonderada = 0;

            for (int i = 0; i < quant; i += 1)
            {
                Console.Write($"Digite a nota {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine());

                Console.Write($"Digite o peso da nota {i + 1}: ");
                pesos[i] = double.Parse(Console.ReadLine());
                Console.Clear();

                somaPonderada += notas[i] * pesos[i];
                somaPesos += pesos[i];
            }

            Console.Clear();
            double mediaPonderada = somaPonderada / somaPesos;
            Console.WriteLine($"A média ponderada das notas é: {mediaPonderada}");
            Console.ReadKey();
        }

        //70
        public static void Caixa()
        {
            Console.WriteLine("Bem-vindo ao Caixa");
            Console.Write("Digite o valor do depósito: ");
            int depositado = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite o valor do saque: ");
            int saque = int.Parse(Console.ReadLine());
            Console.Clear();

            if (saque > depositado)
            {
                Console.WriteLine("Não é possível sacar o valor solicitado, o valor depositado é inferior ao saque.");
                Console.ReadKey();
            }
            else
            {
                int[] notas = { 100, 50, 20, 10, 5, 2 };
                int[] quantNotas = new int[notas.Length];

                for (int i = 0; i < notas.Length; i++)
                {
                    if (saque >= notas[i])
                    {
                        quantNotas[i] = saque / notas[i];
                        saque %= notas[i];
                    }
                }

                Console.WriteLine("Distribuição de notas:");
                for (int i = 0; i < notas.Length; i++)
                {
                    if (quantNotas[i] > 0)
                    {
                        Console.WriteLine($"{quantNotas[i]} nota(s) de R$ {notas[i]}");
                    }
                }
                Console.ReadKey();
            }
        }

        //71
        public static bool Comparar_Arrays(int[] array71, int[] array72)
        {
            if (array71.Length != array72.Length)
            {
                return false;
            }

            for (int i = 0; i < array71.Length; i += 1)
            {
                if (array71[i] != array72[i])
                {
                    return false;
                }
            }

            return true;
        }

        //72
        public static string Senha_Aleatoria(int tam)
        {
            const string charac = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder senha = new StringBuilder();
            Random aleatoria = new Random();

            for (int i = 0; i < tam; i += 1)
            {
                int index = aleatoria.Next(charac.Length);
                senha.Append(charac[index]);
            }

            return senha.ToString();
        }

        //73
        public static void Tabela_Multiplicacao()
        {
            Console.WriteLine("Digite o número de tabelas de multiplicação:");
            int tam = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o número de multiplicações por tabela:");
            int tam2 = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= tam; i += 1)
            {
                Console.WriteLine($"Tabela de multiplicação de {i}:");

                for (int index = 1; index <= tam2; index += 1)
                {
                    Console.Write($"{i * index}\n");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        //74
        public static double Calcular_Area_Triangulo(double lado1, double lado2, double lado3)
        {
            double perimetro = (lado1 + lado2 + lado3) / 2;
            double area = Math.Sqrt(perimetro * (perimetro - lado3) * (perimetro - lado3) * (perimetro - lado3));
            return area;
        }

        //75
        public static List<int> Numeros_Aleatorios_Unicos(int num)
        {
            List<int> numeros = new List<int>();
            Random aleatorio = new Random();

            while (numeros.Count < num)
            {
                int numero = aleatorio.Next(1, num + 1);
                if (!numeros.Contains(numero))
                {
                    numeros.Add(numero);
                }
            }

            return numeros;
        }
    }
}
