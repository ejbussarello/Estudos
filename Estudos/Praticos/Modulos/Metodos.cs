using System;

namespace Estudos.Praticos.Modulos;

public class Metodos
{
    public static void MetodoSimples()
    {
        static void Saudacao()
        {
            Console.WriteLine("Olá, seja bem-vindo(a)!");
        }

        Saudacao(); // Output: Olá, seja bem-vindo(a)!
    }

    public static void MetodoComParametros()
    {
        static void Saudacao_parametro(string nome)
        {
            Console.WriteLine($"Olá, {nome}!");
        }

        Saudacao_parametro("Eduardo"); // Output: Olá, Eduardo!
        Saudacao_parametro("Carol");  // Output: Olá, Carol!
    }

    public static void MetodoComParametrosEntreVirgulas()
    {
        static void Saudacao_param_virgula(string nome, string saudacao)
        {
            Console.WriteLine($"{saudacao}, {nome}!");
        }

        Saudacao_param_virgula("Eduardo", "Olá"); // Output: Olá, Eduardo!
        Saudacao_param_virgula("Carol", "Bem-vinda"); // Output: Bem-vinda, Carol!
    }

    public static void MetodoComParametrosNomeados()
    {
        static void Saudacao_param_nomeado(string nome, string saudacao)
        {
            Console.WriteLine($"{saudacao}, {nome}!");
        }

        Saudacao_param_nomeado(nome: "Eduardo", saudacao: "Olá"); // Output: Olá, Eduardo!
        Saudacao_param_nomeado(saudacao: "Bem-vinda", nome: "Carol"); // Output: Bem-vinda, Carol!
    }

    public static void MetodoComParametrosPadrao()
    {
        static void Saudacao_param_padrao(string nome, string saudacao = "Olá")
        {
            Console.WriteLine($"{saudacao}, {nome}!");
        }

        Saudacao_param_padrao("Eduardo"); // Output: Olá, Eduardo!
        Saudacao_param_padrao("Carol", "Bem-vinda"); // Output: Bem-vinda, Carol!
    }

    public static void MetodoComRetorno()
    {
        // Função com retorno
        int Somar(int a, int b)
        {
            return a + b;
        }

        int resultado = Somar(5, 3);
        Console.WriteLine($"Resultado da soma: {resultado}"); // Output: Resultado da soma: 8

        Console.WriteLine(Somar(10, 5) * 2); // Output: 30
    }

    public static void MetodoComRetornoComTupla()
    {
        // Função que retorna uma tupla
        (int, int) GetCoordinates()
        {
            int x = 10;
            int y = 20;
            return (x, y);
        }

        var coordinates = GetCoordinates();
        Console.WriteLine($"Coordenadas: ({coordinates.Item1}, {coordinates.Item2})"); // Output: Coordenadas: (10, 20)

        // Desconstruindo a tupla em variáveis separadas
        var (xCoord, yCoord) = GetCoordinates();
        Console.WriteLine($"Coordenadas desconstruídas: ({xCoord}, {yCoord})"); // Output: Coordenadas desconstruídas: (10, 20)
    }

    public static void MetodoVoid()
    {
        // Método void não retorna um valor utilizável
        void Add(int a, int b)
        {
            Console.WriteLine(a + b); // Mostra o resultado, mas não retorna um valor
        }

        Add(3, 4); // Output: 7

        // int x = Add(3, 4); // Erro de compilação: não é possível atribuir o resultado de um método void a uma variável
    }

    public static void MetodoArray()
    {
        int[] a = {1,2,3,4,5};

        Console.WriteLine("Contents of Array:");
        PrintArray();

        void PrintArray()
        {
            foreach (int x in a)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }
    }

    public static void ExecicioMetodo()
    {
        int[] times = {800, 1200, 1600, 2000};
        int diff = 0;

        Console.WriteLine("Enter current GMT");
        int currentGMT = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Current Medicine Schedule:");
        DisplayTimes();

        Console.WriteLine("Enter new GMT");
        int newGMT = Convert.ToInt32(Console.ReadLine());

        if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
        {
            Console.WriteLine("Invalid GMT");
        }
        else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
        {
            diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
            AdjustTimes();
        } 
        else 
        {
            diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
            AdjustTimes();
        }

        Console.WriteLine("New Medicine Schedule:");
        DisplayTimes();

        void DisplayTimes()
        {
            /* Format and display medicine times */
            foreach (int val in times)
            {
                string time = val.ToString();
                int len = time.Length;

                if (len >= 3)
                {
                    time = time.Insert(len - 2, ":");
                }
                else if (len == 2)
                {
                    time = time.Insert(0, "0:");
                }
                else
                {
                    time = time.Insert(0, "0:0");
                }

                Console.Write($"{time} ");
            }
            Console.WriteLine();
        }

        void AdjustTimes() 
        {
            /* Adjust the times by adding the difference, keeping the value within 24 hours */
            for (int i = 0; i < times.Length; i++) 
            {
                times[i] = ((times[i] + diff)) % 2400;
            }
        }
    }

    public static void ExecicioMetodo2()
    {
        string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
        string[] address;
        bool validLength = false;
        bool validZeroes = false;
        bool validRange = false;

        foreach (string ip in ipv4Input) 
        {
            address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

            ValidateLength(); 
            ValidateZeroes(); 
            ValidateRange();

            if (validLength && validZeroes && validRange) 
            {
                Console.WriteLine($"{ip} is a valid IPv4 address");
            } 
            else 
            {
                Console.WriteLine($"{ip} is an invalid IPv4 address");
            }
        }

        void ValidateLength() 
        {
            validLength = address.Length == 4;
        };

        void ValidateZeroes() 
        {
            foreach (string number in address) 
            {
                if (number.Length > 1 && number.StartsWith("0")) 
                {
                    validZeroes = false;
                    return;
                }
            }

            validZeroes = true;
        }

        void ValidateRange() 
        {
            foreach (string number in address) 
            {
                int value = int.Parse(number);
                if (value < 0 || value > 255) 
                {
                    validRange = false;
                    return;
                }
            }
            validRange = true;
        }
    }

    public static void ExecicioMetodo3()
    {
        Random random = new Random();
        int luck = random.Next(100);

        string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
        string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
        string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
        string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

        TellFortune();

        void TellFortune() 
        {
            Console.WriteLine("A fortune teller whispers the following words:");
            string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
            for (int i = 0; i < 4; i++) 
            {
                Console.Write($"{text[i]} {fortune[i]} ");
            }
        }
    }

    public static void TestarPassagem()
    {
        int a = 3;
        int b = 4;
        int c = 0;

        Multiply(a, b, c);
        Console.WriteLine($"global statement: {a} x {b} = {c}");

        void Multiply(int a, int b, int c) 
        {
            c = a * b;
            Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
        }
    }

    public static void PorReferencia()
    {
        int[] array = {1, 2, 3, 4, 5};

        PrintArray(array);
        Clear(array);
        PrintArray(array);

        void PrintArray(int[] array) 
        {
            foreach (int a in array) 
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
        }

        void Clear(int[] array) 
        {
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = 0;
            }
        }
    }

    public static void CadeiaCaracteres()
    {
        string status = "Healthy";

        Console.WriteLine($"Start: {status}");
        SetHealth(false);
        Console.WriteLine($"End: {status}");

        void SetHealth(bool isHealthy) 
        {
            status = (isHealthy ? "Healthy" : "Unhealthy");
            Console.WriteLine($"Middle: {status}");
        }
    }

    public static void ParametrosOpcionais()
    {
        string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
        string[] rsvps = new string[10];
        int count = 0;

        RSVP("Rebecca");
        RSVP("Nadia", 2, "Nuts");
        RSVP(name: "Linh", partySize: 2, inviteOnly: false);
        RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
        RSVP("Noor", 4, inviteOnly: false);
        RSVP("Jonte", 2, "Stone fruit", false);
        ShowRSVPs();

        void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
        {
            if (inviteOnly)
            {
                if (inviteOnly)
                {
                    bool found = false;
                    foreach (string guest in guestList)
                    {
                        if (guest.Equals(name)) {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine($"Sorry, {name} is not on the guest list");
                        return;
                    }
                }
            }

            rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
            count++;
        }

        void ShowRSVPs()
        {
            Console.WriteLine("\nTotal RSVPs:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(rsvps[i]);
            }
        }
    }

    public static void ReverseWord()
    {
        string input = "there are snakes at the zoo";

        Console.WriteLine(input);
        Console.WriteLine(ReverseSentence(input));

        string ReverseSentence(string input) 
        {
            string result = "";
            string[] words = input.Split(" ");
            foreach(string word in words) 
            {
                result += ReverseWord(word) + " ";
            }
            return result.Trim();
        }

        string ReverseWord(string word) 
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--) 
            {
                result += word[i];
            }
            return result;
        }
    }

    public static void Polindrome()
    {
        string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

        Console.WriteLine("Is it a palindrome?");
        foreach (string word in words) 
        {
            Console.WriteLine($"{word}: {IsPalindrome(word)}");
        }

        bool IsPalindrome(string word) 
        {
            int start = 0;
            int end = word.Length - 1;

            while (start < end) 
            {
                if (word[start] != word[end]) 
                {
                    return false;
                }
                start++;
                end--;
            }

            return true;
        }
    }

    public static void Target()
    {
        int target = 30;
        int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
        int[,] result = TwoCoins(coins, target);

        if (result.Length == 0) 
        {
            Console.WriteLine("No two coins make change");
        } 
        else 
        {
            Console.WriteLine("Change found at positions:");
            for (int i = 0; i < result.GetLength(0); i++) 
            {
                if (result[i,0] == -1) 
                {
                    break;
                }
                Console.WriteLine($"{result[i,0]},{result[i,1]}");
            }
        }

        int[,] TwoCoins(int[] coins, int target) 
        {
            int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
            int count = 0;

            for (int curr = 0; curr < coins.Length; curr++) 
            {
                for (int next = curr + 1; next < coins.Length; next++) 
                {    
                    if (coins[curr] + coins[next] == target) 
                    {
                        result[count, 0] = curr;
                        result[count, 1] = next;
                        count++;
                    }
                    if (count == result.GetLength(0)) 
                    {
                        return result;
                    }
                }
            }
            return (count == 0) ? new int[0,0] : result;
        }
    }

}
