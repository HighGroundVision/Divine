﻿using HGV.Divine.Numerics;

namespace HGV.Divine
{
    public class TeamsRange : Range<TeamsRange>
    {
        public TeamsRange()
            : base(int.MinValue, int.MinValue)
        {
        }

        private TeamsRange(int min, int max)
            : base(min, max)
        {
        }

        protected override TeamsRange Create(int min, int max)
        {
            return new TeamsRange(min, max);
        }
    }
}