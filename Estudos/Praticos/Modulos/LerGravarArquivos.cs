using System;


namespace Estudos.Praticos.Modulos;

public class LerGravarArquivos
{


}


/*
        // Você pode abrir um arquivo com um StreamReader e fechá-lo com .Close():

        StreamReader reader = new StreamReader("notes.txt");
        string contents = reader.ReadToEnd();
        Console.WriteLine(contents);
        reader.Close();


        // Usando a instrução `using`
        using (StreamReader reader = new StreamReader("notes.txt"))
        {
            string contents = reader.ReadToEnd();
            Console.WriteLine(contents);
        }

        // Declaração de uso mais curta (C# 8.0 ou superior)
        using StreamReader reader = new StreamReader("notes.txt");
        string contents = reader.ReadToEnd();
        Console.WriteLine(contents);
        

        // Você pode abrir um arquivo com um StreamWriter e fechá-lo com .Close():
        string contents = File.ReadAllText("notes.txt");
        Console.WriteLine(contents);

*/