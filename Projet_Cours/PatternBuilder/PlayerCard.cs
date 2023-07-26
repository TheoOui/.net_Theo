using System;
using System.Collections.Generic;

public class PlayerCard
{
    static void Main(string[] args)
    {
        FootballTeam team = FootballTeam.GetInstance();

        // Utilisation du FootballPlayerBuilder pour créer le joueur Messi
        FootballPlayerBuilder builder = new FootballPlayerBuilder();
        FootballPlayer messi = builder
            .SetName("Messi")
            .SetSpeed(90)
            .SetShooting(95)
            .SetPassing(90)
            .SetDribbling(96)
            .SetPhysicals(75)
            
            .Build();

        team.AddPlayer(messi);

       
        FootballPlayerBuilder builder2 = new FootballPlayerBuilder();
        FootballPlayer ronaldo = builder2
            .SetName("Ronaldo")
            .SetSpeed(92)
            .SetShooting(97)
            .SetPassing(85)
            .SetDribbling(90)
            .SetPhysicals(80)
            
            .Build();

        team.AddPlayer(ronaldo);
        
        FootballPlayerBuilder builder3 = new FootballPlayerBuilder();
FootballPlayer neymar = builder3
    .SetName("Neymar")
    .SetSpeed(92)
    .SetShooting(88)
    .SetPassing(85)
    .SetDribbling(95)
    .SetPhysicals(75)
    
    .Build();
        team.AddPlayer(neymar);


FootballPlayerBuilder builder4 = new FootballPlayerBuilder();
 FootballPlayer lewandowski= builder4
    .SetName("Lewandowski")
    .SetSpeed(85)
    .SetShooting(94)
    .SetPassing(80)
    .SetDribbling(80)
    .SetPhysicals(85)
    
    .Build();   
            team.AddPlayer(lewandowski);

            // Utilisation du FootballPlayerBuilder pour créer un autre joueur
FootballPlayerBuilder builder5 = new FootballPlayerBuilder();
FootballPlayer mbappe = builder5
    .SetName("Mbappe")
    .SetSpeed(96)
    .SetShooting(87)
    .SetPassing(80)
    .SetDribbling(92)
    .SetPhysicals(78)
    .Build();

team.AddPlayer(mbappe);

// Utilisation du FootballPlayerBuilder pour créer un autre joueur
FootballPlayerBuilder builder6 = new FootballPlayerBuilder();
FootballPlayer deBruyne = builder6
    .SetName("De Bruyne")
    .SetSpeed(84)
    .SetShooting(89)
    .SetPassing(92)
    .SetDribbling(86)
    .SetPhysicals(78)
    .Build();

team.AddPlayer(deBruyne);

// Utilisation du FootballPlayerBuilder pour créer un autre joueur
FootballPlayerBuilder builder7 = new FootballPlayerBuilder();
FootballPlayer zlatan = builder7
    .SetName("Zlatan")
    .SetSpeed(75)
    .SetShooting(94)
    .SetPassing(85)
    .SetDribbling(80)
    .SetPhysicals(88)
    .Build();

team.AddPlayer(zlatan);

// Utilisation du FootballPlayerBuilder pour créer un autre joueur
FootballPlayerBuilder builder8 = new FootballPlayerBuilder();
FootballPlayer cozza = builder8
    .SetName("Cozza")
    .SetSpeed(82)
    .SetShooting(75)
    .SetPassing(85)
    .SetDribbling(83)
    .SetPhysicals(80)
    .Build();

team.AddPlayer(cozza);

// Utilisation du FootballPlayerBuilder pour créer un autre joueur
FootballPlayerBuilder builder9 = new FootballPlayerBuilder();
FootballPlayer cabella = builder9
    .SetName("Cabella")
    .SetSpeed(79)
    .SetShooting(81)
    .SetPassing(84)
    .SetDribbling(86)
    .SetPhysicals(76)
    .Build();

team.AddPlayer(cabella);

// Utilisation du FootballPlayerBuilder pour créer un autre joueur
FootballPlayerBuilder builder10 = new FootballPlayerBuilder();
FootballPlayer giroud = builder10
    .SetName("Giroud")
    .SetSpeed(75)
    .SetShooting(87)
    .SetPassing(78)
    .SetDribbling(79)
    .SetPhysicals(85)
    .Build();

team.AddPlayer(giroud);


        // Afficher la liste des joueurs disponibles
        Console.WriteLine("Liste des joueurs disponibles :");
        foreach (var player in team.GetPlayers())
        {
            Console.WriteLine(player.Name);
        }

        // Demander à l'utilisateur de choisir un joueur
        Console.Write("\nEntrez le nom du joueur choisi : ");
        string chosenPlayerName = Console.ReadLine();

        // Recherche du joueur choisi dans l'équipe
        FootballPlayer chosenPlayer = team.GetPlayerByName(chosenPlayerName);

        // Vérification si le joueur existe dans l'équipe
        if (chosenPlayer != null){
         Console.Write($"Combien de buts {chosenPlayer.Name} a-t-il marqué cette saison ? ");
            int goalsScored = int.Parse(Console.ReadLine());
            // Mettre à jour le nombre de buts marqués pour le joueur sélectionné
            chosenPlayer.GoalsScored = goalsScored;

                
            Console.WriteLine($"\nStatistiques du joueur {chosenPlayer.Name} :");
            Console.WriteLine($"Vitesse : {chosenPlayer.Speed}");
            Console.WriteLine($"Tir : {chosenPlayer.Shooting}");
            Console.WriteLine($"Passes : {chosenPlayer.Passing}");
            Console.WriteLine($"Dribbles : {chosenPlayer.Dribbling}");
            Console.WriteLine($"Physiques : {chosenPlayer.Physicals}");
            Console.WriteLine($"Nombre de buts marqués : {chosenPlayer.GoalsScored}");
            // Modification : Utilisation de la stratégie pour calculer la note finale
            INoteCalculationStrategy strategy = new GlobalRatingStrategy();
            double overallRating = chosenPlayer.CalculateOverallRating(strategy);
            Console.WriteLine($"Note finale : {overallRating}");

             INoteCalculationStrategy dribbleStrategy = new DribbleRatingStrategy();
            chosenPlayer.CalculateOverallRating(dribbleStrategy);
        }   

        else
        {
            Console.WriteLine("Joueur non trouvé dans l'équipe.");
        }

        Console.ReadLine();
    }
}
