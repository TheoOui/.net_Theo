using System;
using System.Collections.Generic;

public class FootballTeam
{

    private static FootballTeam instance ;
    private List<FootballPlayer> players = new List<FootballPlayer>();

    private FootballTeam(){}

     // Méthode pour obtenir l'instance unique de FootballTeam (Singleton)
    public static FootballTeam GetInstance()
    {
        if (instance == null)
        {
            instance = new FootballTeam();
        }
        return instance;
    }

    public void AddPlayer(FootballPlayer player)
    {
        players.Add(player);
    }

    public void DisplayPlayersStats(INoteCalculationStrategy strategy)
    {
        foreach (var player in players)
        {
            Console.WriteLine($"Joueur : {player.Name}");
            Console.WriteLine($"Vitesse : {player.Speed}");
            Console.WriteLine($"Tir : {player.Shooting}");
            Console.WriteLine($"Passes : {player.Passing}");
            Console.WriteLine($"Dribbles : {player.Dribbling}");
            Console.WriteLine($"Physiques : {player.Physicals}");
            Console.WriteLine($"Nombre de buts marqués : {player.GoalsScored}");
            double overallRating = player.CalculateOverallRating(strategy);
            Console.WriteLine($"Note finale : {overallRating}");
            Console.WriteLine();
        }
    }

    public List<FootballPlayer> GetPlayers()
    {
        return players;
    }

    public FootballPlayer GetPlayerByName(string name)
    {
        return players.Find(player => player.Name == name);
    }
}
