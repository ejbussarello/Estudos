using System;
using System.ComponentModel;

namespace Estudos.Praticos;

public static class AppPet
{

    public static void Main()
    {

        // A Lista ourAnimal, irá guardar as seguintes informações:
        string animalSpecies = "";
        string animalID = "";
        string animalAge = "";
        string animalPhysicalDescription = "";
        string animalPersonalityDescription = "";
        string animalNickname = "";

        // variables that support data entry
        int maxPets = 8;
        string? readResult;
        string menuSelection = "";

        // Lista utilizada para armazenar em tempo de execução, sem persistência Matriz : 8x6
        string[,] ourAnimals = new string[maxPets, 6];

        // TODO: Convert the if-elseif-else construct to a switch statement

        // create some initial ourAnimals array entries
        for (int i = 0; i < maxPets; i++)
        {
            switch (i)
            {
                case 0:
                    animalSpecies = "dog";
                    animalID = "d1";
                    animalAge = "2";
                    animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                    animalNickname = "lola";
                    break;

                case 1:
                    animalSpecies = "dog";
                    animalID = "d2";
                    animalAge = "9";
                    animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                    animalNickname = "loki";
                    break;

                case 2:
                    animalSpecies = "cat";
                    animalID = "c3";
                    animalAge = "1";
                    animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                    animalPersonalityDescription = "friendly";
                    animalNickname = "Puss";
                    break;

                case 3:
                    animalSpecies = "cat";
                    animalID = "c4";
                    animalAge = "?";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    break;

                default:
                    animalSpecies = "";
                    animalID = "";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    break;

            }

            ourAnimals[i, 0] = "ID #: " + animalID;
            ourAnimals[i, 1] = "Species: " + animalSpecies;
            ourAnimals[i, 2] = "Age: " + animalAge;
            ourAnimals[i, 3] = "Nickname: " + animalNickname;
            ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
        }

        do
        {
            // display the top-level menu options

            Console.Clear();

            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine(" 1. List all of our current pet information");
            Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
            Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
            Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
            Console.WriteLine(" 5. Edit an animal’s age");
            Console.WriteLine(" 6. Edit an animal’s personality description");
            Console.WriteLine(" 7. Display all cats with a specified characteristic");
            Console.WriteLine(" 8. Display all dogs with a specified characteristic");
            Console.WriteLine(" 9. Sair");
            Console.WriteLine();
            Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                menuSelection = readResult.ToLower();
            }

            switch (menuSelection)
            {
                case "1":
                    // List all of our current pet information
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i, 0] != "ID #: ")
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 6; j++)
                            {
                                Console.WriteLine(ourAnimals[i, j]);
                            }
                        }
                    }
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                case "2":
                    // Add a new animal friend to the ourAnimals array
                    
                    string anotherPet = "y";
                    int petCount = 0;

                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i,0] != "ID #: ")
                        {
                            petCount += 1;
                        }
                    }
                    
                    if (petCount < maxPets)
                    {
                        Console.WriteLine($"Nós temos atualmente {petCount} animais que necessitam de uma casa. Além destes, cuidamos de {(maxPets - petCount)} mais.");
                    }

                    while (anotherPet == "y" && petCount < maxPets)
                    {
                        bool validEntry = false;

                        // pegar espécie - string animalSpecies is a required field
                        do
                        {
                            Console.WriteLine("\n\rInsira 'dog' ou 'cat' para iniciar uma nova entrada");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalSpecies = readResult.ToLower();

                                if (animalSpecies != "dog" && animalSpecies != "cat")
                                {
                                    validEntry = false;
                                } else
                                {
                                    validEntry = true;
                                }
                            }
                            
                        } while (validEntry == false);

                        animalID = animalSpecies.Substring(0,1) + (petCount + 1).ToString();

                        do
                        {
                            int petAge;

                            Console.WriteLine("Insira a idade do animal, ou '?' caso seja desconhecido");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalAge = readResult;
                            
                                if (readResult != "?")
                                {
                                    validEntry = int.TryParse(animalAge, out petAge);
                                } else
                                {
                                    validEntry = true;
                                }

                            }

                        } while (validEntry == false);

                        do
                        {
                            Console.WriteLine("Insira uma descrição física do animal (cor, tamanho, sexo, peso)");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalPhysicalDescription = readResult.ToLower();
                                if (animalPersonalityDescription == "")
                                {
                                    animalPhysicalDescription = "tdb";
                                }
                            }
                        } while (animalPhysicalDescription == "");

                        do
                        {
                            Console.WriteLine("Insira a descrição da personalidade do animal (amigável, nervoso, traiçoeiro e o nível de enegia)");
                            readResult = Console.ReadLine();
                            
                            if (readResult != null)
                            {
                                animalPersonalityDescription = readResult.ToLower();
                                if (animalPersonalityDescription == "")
                                {
                                    animalPersonalityDescription = "tbd";
                                }
                            }
                        } while (animalPersonalityDescription == "");

                        do
                        {
                            Console.WriteLine("Insira o apelido do animal");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalNickname = readResult.ToLower();
                                if (animalNickname == "")
                                {
                                    animalNickname = "tbd";
                                }
                            }
                        } while (animalNickname == "");

                        ourAnimals[petCount, 0] = "ID #: "             + animalID;
                        ourAnimals[petCount, 1] = "Espécie: "          + animalSpecies;
                        ourAnimals[petCount, 2] = "Idade #: "          + animalAge;
                        ourAnimals[petCount, 3] = "Apelido #: "        + animalNickname;
                        ourAnimals[petCount, 4] = "Descricao Física: " + animalPhysicalDescription;
                        ourAnimals[petCount, 5] = "Personalidade: "    + animalPersonalityDescription;

                        // incrementa petCount - a array é zero-based, então nós acrescentamos o contatod depois de adicionar na array
                        petCount = petCount + 1;
                        
                        // checa o limite de maxPet
                        if (petCount < maxPets)
                        {
                            // outro animal?
                            Console.WriteLine("Deseja incluir informações para outro animal?");
                            do
                            {
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    anotherPet = readResult.ToLower();
                                }

                            } while (anotherPet != "y" && anotherPet != "n");
                        }
                    }
                    
                    if (petCount >= maxPets)
                    {
                        Console.WriteLine("Nós chegamos no nosso limite de numero de animais que podemos gerenciar.");
                        Console.WriteLine("Pressiona qualquer tecla para continuar.");
                        readResult = Console.ReadLine();
                    }
                    
                    break;

                case "3":
                    
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i,2] == "Age: ?")
                        {
                            bool validEntry = false;

                            do
                            {
                                int petAge;

                                Console.WriteLine($"Informe uma idade para o animal {ourAnimals[i,0]}, ou '?' se for desconhecido");
                                readResult = Console.ReadLine();

                                if (readResult != null)
                                {
                                    animalAge = readResult;
                                
                                    if (readResult != "?")
                                    {
                                        validEntry = int.TryParse(animalAge, out petAge);
                                    } else
                                    {
                                        validEntry = true;
                                    }

                                }

                            } while (validEntry == false);

                            ourAnimals[i,2] = "Age: " + animalAge;

                        }

                        if (ourAnimals[i,4] == "")
                        {
                            do
                            {
                                Console.WriteLine("Insira uma descrição física do animal (cor, tamanho, sexo, peso)");
                                readResult = Console.ReadLine();

                                if (readResult != null)
                                {
                                    animalPhysicalDescription = readResult.ToLower();
                                    if (animalPersonalityDescription == "")
                                    {
                                        animalPhysicalDescription = "tdb";
                                    }
                                }
                            } while (animalPhysicalDescription == "");
                        }
                    }
                    
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                case "4":
                    // Ensure animal nicknames and personality descriptions are complete
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                case "5":
                    // Edit an animal’s age
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                case "6":
                    // Edit an animal’s personality description
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "7":
                    // Display all cats with a specified characteristic
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                case "8":
                    // Display all dogs with a specified characteristic
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                case "9":
                    // Sair
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

            }

        } while (menuSelection != "9");

    }

}