using System;

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

     public double CalculateOverallRating(INoteCalculationStrategy strategy)
    {
        return strategy.CalculateOverallRating(this);
    }

     public object Clone()
    {
        // Utilisation d'un clonage superficiel (MemberwiseClone) car les propriétés sont de types primitifs
        return this.MemberwiseClone();
    }
}
