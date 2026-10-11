using System;

namespace Estudos.Praticos.Modulos;

public static class SwitchCase
{
    public static void NivelFuncionario()
    {
        int levelFuncionario = 200;
        string nomeFuncionario = "Eduardo";

        string titulo = "";

        switch (levelFuncionario)
        {
            case 100:
                titulo = "Programador Júnior";
                break;
            case 200:
                titulo = "Programador Pleno";
                break;
            case 300:
                titulo = "Programador Sênior";
                break;
            case 400:
                titulo = "CTO";
                break;
            default:
                titulo = "CEO";
                break;
        }

        Console.WriteLine($"{nomeFuncionario}, {titulo}");
    }

    public static void ModeloComIf()
    {
        // SKU = Stock Keeping Unit. 
        // SKU value format: <product #>-<2-letter color code>-<size code>
        string sku = "01-MN-L";

        string[] product = sku.Split('-');

        string type = "";
        string color = "";
        string size = "";

        if (product[0] == "01")
        {
            type = "Sweat shirt";
        } else if (product[0] == "02")
        {
            type = "T-Shirt";
        } else if (product[0] == "03")
        {
            type = "Sweat pants";
        }
        else
        {
            type = "Other";
        }

        if (product[1] == "BL")
        {
            color = "Black";
        } else if (product[1] == "MN")
        {
            color = "Maroon";
        } else
        {
            color = "White";
        }

        if (product[2] == "S")
        {
            size = "Small";
        } else if (product[2] == "M")
        {
            size = "Medium";
        } else if (product[2] == "L")
        {
            size = "Large";
        } else
        {
            size = "One Size Fits All";
        }

        Console.WriteLine($"Product: {size} {color} {type}");
    }

    public static void ModeloComSwitchCase()
    {
        string sku = "01-AZ-M";

        string[] product = sku.Split('-');

        string type = "";
        string color = "";
        string size = "";

        switch(product[0])
        {
            case "01" : 
            type = "Casaco Moletom";
            break;

            case "02" :
            type = "Camiseta";
            break;

            case "03" :
            type = "Calça Moletom";
            break;

            default : 
            type = "Outro";
            break;
        }

        switch(product[1])
        {
            case "BL" : 
            color = "Preto";
            break;

            case "AZ" : 
            color = "Azul";
            break;

            default :
            color = "White";
            break;
            
        }

        switch(product[2])
        {
            case "P" : 
            size = "Tamanho P";
            break;

            case "M" :
            size = "Tamanho M";
            break;

            case "G" :
            size = "Tamanho G";
            break;

            default : 
            size = "Tamanho GG";
            break;
        }

        Console.WriteLine($"Produto: {type} {color} {size}");
    }

}
