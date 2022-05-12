using System;

namespace PlayerManager4
{
    public class Player : IComparable<Player>
    {
        public string Name { get; }
        public int Score { get; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int CompareTo(Player other)
        {
            return other.Score - Score;
        }
    }
}
