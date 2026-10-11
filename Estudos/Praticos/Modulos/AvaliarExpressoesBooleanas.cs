namespace Estudos.Praticos.Modulos;

public static class AvaliarExpressoesBooleanas
{
    
    public static void CaraOuCoroa()
    {
        Random moeda = new Random();
        int flip = moeda.Next(0, 2);
        Console.WriteLine((flip == 0) ? "Cara" : "Coroa");    
    }

    public static void CaraOuCoroaResumida()
    {
        Random moeda = new Random();
        Console.WriteLine((moeda.Next(0, 2) == 0) ? "Cara" : "Coroa");
    }
}
