using System ;

public class FootballPlayer
{
    // Propriétés du joueur
    public string Name { get; set; }
    public int Speed { get; set; }
    public int Shooting { get; set; }
    public int Passing { get; set; }
    public int Dribbling { get; set; }
    public int Physicals { get; set; }
    public int GoalsScored { get; set; }

    // Méthode pour calculer la note finale
    public double CalculateOverallRating()
    {
        // Calcul de la moyenne des 5 stats
        double averageStats = (Speed + Shooting + Passing + Dribbling + Physicals) / 5.0;

        // Ajout du bonus pour les buts marqués
        int goalBonus = GoalsScored / 5;

        // Calcul de la note finale avec le bonus
        double overallRating = averageStats + goalBonus;

        return overallRating;
    }
}
