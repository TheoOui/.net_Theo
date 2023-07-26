using System ;
public class GlobalRatingStrategy : INoteCalculationStrategy
{
    public double CalculateOverallRating(FootballPlayer player)
    {
        // Calcul de la moyenne des 5 stats
        double averageStats = (player.Speed + player.Shooting + player.Passing + player.Dribbling + player.Physicals) / 5.0;

        // Ajout du bonus pour les buts marqués
        int goalBonus = player.GoalsScored / 5;

        // Calcul de la note finale avec le bonus
        double overallRating = averageStats + goalBonus;

        return overallRating;
    }
}