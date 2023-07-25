using System ;

public class FootballPlayerBuilder
{
    private FootballPlayer player = new FootballPlayer();

    public FootballPlayerBuilder SetName(string name)
    {
        player.Name = name;
        return this;
    }

    public FootballPlayerBuilder SetSpeed(int speed)
    {
        player.Speed = speed;
        return this;
    }

    public FootballPlayerBuilder SetShooting(int shooting)
    {
        player.Shooting = shooting;
        return this;
    }

    public FootballPlayerBuilder SetPassing(int passing)
    {
        player.Passing = passing;
        return this;
    }

    public FootballPlayerBuilder SetDribbling(int dribbling)
    {
        player.Dribbling = dribbling;
        return this;
    }

    public FootballPlayerBuilder SetPhysicals(int physicals)
    {
        player.Physicals = physicals;
        return this;
    }

    public FootballPlayerBuilder SetGoalsScored(int goalsScored)
    {
        player.GoalsScored = goalsScored;
        return this;
    }

    public FootballPlayer Build()
    {
        return player;
    }
}
