using System;
using System.Collections.Generic;

public class FootballTeam
{
    private List<FootballPlayer> players = new List<FootballPlayer>();

    public void AddPlayer(FootballPlayer player)
    {
        players.Add(player);
    }

    public void DisplayPlayersStats()
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
            Console.WriteLine($"Note finale : {player.CalculateOverallRating()}");
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
