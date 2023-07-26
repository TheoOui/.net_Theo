public class PlayerStatsAdapter : INoteDisplayAdapter
{
    public void DisplayPlayerStats(FootballPlayer player)
    {
        // Utiliser les stratégies pour calculer les notes du joueur
        INoteCalculationStrategy strategy = new GlobalRatingStrategy();
        double overallRating = player.CalculateOverallRating(strategy);

        INoteCalculationStrategy dribbleStrategy = new DribbleRatingStrategy();
        player.CalculateOverallRating(dribbleStrategy);

        // Cloner le joueur
        FootballPlayer clonedPlayer = (FootballPlayer)player.Clone();

        // Amélioration des statistiques du joueur cloné
        clonedPlayer.Speed++;
        clonedPlayer.Shooting++;
        clonedPlayer.Passing++;
        clonedPlayer.Dribbling++;
        clonedPlayer.Physicals++;

        // Afficher les statistiques du joueur
        Console.WriteLine($"\nStatistiques du joueur {player.Name} :");
        Console.WriteLine($"Vitesse : {player.Speed}");
        Console.WriteLine($"Tir : {player.Shooting}");
        Console.WriteLine($"Passes : {player.Passing}");
        Console.WriteLine($"Dribbles : {player.Dribbling}");
        Console.WriteLine($"Physiques : {player.Physicals}");
        Console.WriteLine($"Nombre de buts marqués : {player.GoalsScored}");
        Console.WriteLine($"Note finale : {overallRating}");

        // Afficher les statistiques du joueur cloné amélioré
        Console.WriteLine($"\nStatistiques du joueur {clonedPlayer.Name} (s'il obtient une carte améliorée) :");
        Console.WriteLine($"Vitesse : {clonedPlayer.Speed}");
        Console.WriteLine($"Tir : {clonedPlayer.Shooting}");
        Console.WriteLine($"Passes : {clonedPlayer.Passing}");
        Console.WriteLine($"Dribbles : {clonedPlayer.Dribbling}");
        Console.WriteLine($"Physiques : {clonedPlayer.Physicals}");
        Console.WriteLine($"Nombre de buts marqués : {clonedPlayer.GoalsScored}");
        Console.WriteLine($"Note finale : {clonedPlayer.CalculateOverallRating(strategy)}");
    }
}
