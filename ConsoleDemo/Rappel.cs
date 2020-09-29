using System;

namespace ConsoleDemo
{
    class Rappel
    {
        static void Main(string[] args)
        {
            HelloWorld();
            IfExemple();
            ForExemple();
            WhileExemple();
            SwitchExemple();
        }

        /// <summary>
        /// Fonction permettant d'afficher Hello World ! puis attendant que l'utilisateur appui sur Entrée avant de 
        /// continuer l'exécution du programme
        /// </summary>
        static  void HelloWorld()
        {
            Console.WriteLine("Hello World !"); // On écrit Hello  World ! dans la fenêtre  console
            Console.ReadLine();  // On attend que la personne appui sur entrée pour finir l'exécution du programme
        }

        /// <summary>
        /// Fonction permettant de montrer le fonctionnement de la  structure condition identique au C
        /// </summary>
        static void IfExemple()
        {
            string userInput;
            Console.WriteLine("Veuillez taper 1 et appuyer sur Entrée pour sauver le monde");
            userInput = Console.ReadLine();
            if(userInput.Equals("1"))
            {
                Console.WriteLine("Bravo vous avez réussi à respecter la consigne  le monde est sauvé");
            }
            else
            {
                Console.WriteLine("Vous n'avez pas suivi la consigne la fin du monde est proche");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Fonction permettant de rappeler le fonctionnement de la boucle for identique au C
        /// </summary>
        static void ForExemple()
        {
            for(int i=0; i<10; i++) // On va exécuter 10 fois le bloc suivant
            {
                Console.WriteLine(i+1); // On affiche le numéro de l'exécution entre 1 et 10
            }
            Console.ReadLine(); // On attend que la personne appui sur entrée pour finir l'exécution du programme
        }

        /// <summary>
        /// Fonction permettant de rappeler le fonctionnement de la boucle while identique au C
        /// </summary>
        static void WhileExemple()
        {
            bool stop = false; // On initialise le booléen stop à faux
            string userInput; // On crée on objet string pour contenir le retour de l'utilisateur
            while (!stop) // On effectue le bloc suivant tant que stop n'est pas vrai
            { 
                Console.WriteLine("Faites Q et Entrée pour quitter");  // On indique à l'utilisateur comment sortir
                userInput = Console.ReadLine(); // On lit ce que l'utilisateur a saisi
                stop = userInput.Equals("Q"); // On vérifie si l'utilisateur a bien entré Q
            }
            Console.ReadLine();  // On attend que la personne appui sur entrée pour finir l'exécution du programme
        }

        /// <summary>
        /// Fonction permettant de rappeler le fonctionnement de la structure switch identique au C
        /// </summary>
        static void SwitchExemple()
        {
            bool stop = false;
            string userInput;
            while(!stop)
            {
                PrintMenuExemple();
                userInput = Console.ReadLine();
                switch(userInput) // En fonction de ce que l'utilisateur a entré on exécute l'une ou l'autre des fonctions
                {
                    case "1":
                        HelloWorld();
                        break;
                    case "2":
                        ForExemple();
                        break;
                    case "3":
                        stop = true;
                        break;
                    default: // Cas par défaut au cas où l'utilisateur entre une valeur inconnue
                        Console.WriteLine("Vous avez sélectionné une valeur n'existant pas dans le menu");
                        break;
                }
            }
            Console.WriteLine(); // On attend que la personne appui sur entrée pour finir l'exécution du programme
        }

        /// <summary>
        /// Fonction permettant d'écrire le menu du SwitchExemple afin de pouvoir le faire évoluer facilement
        /// </summary>
        static void PrintMenuExemple()
        {
            Console.WriteLine("Bienvenu dans le programme d'exemple du switch");
            Console.WriteLine("Les différentes possibilités de ce programme sont :");
            Console.WriteLine("- 1 : Afficher HelloWorld");
            Console.WriteLine("- 2 : Compter de 1 à 10");
            Console.WriteLine("- 3 : Sortir de ce menu");
            Console.WriteLine("Pensez à appuyer sur Entrée pour réafficher ce menu");
        }
    }
}
