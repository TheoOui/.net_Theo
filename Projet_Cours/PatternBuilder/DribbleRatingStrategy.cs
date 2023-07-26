using System ;
public class DribbleRatingStrategy : INoteCalculationStrategy
{
    public double CalculateOverallRating(FootballPlayer player)
    {
        if (player.Dribbling > 85)
        {
            Console.WriteLine("C'est un bon dribbleur !");
        }
        else
        {
            Console.WriteLine("Ce n'est pas un bon dribbleur.");
        }

        // Retourner la note globale du joueur, car cette stratégie ne modifie pas la note globale.
        return player.CalculateOverallRating(new GlobalRatingStrategy());
    }
}
