using System.Collections.Generic;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private bool ascending;

        public CompareByName(bool ascending)
        {
            this.ascending = ascending;
        }

        public int Compare(Player p1, Player p2)
        {
            if (ascending)
            {
                return p1.Name.CompareTo(p2.Name);
            }
            return p2.Name.CompareTo(p1.Name);
        }
    }
}
