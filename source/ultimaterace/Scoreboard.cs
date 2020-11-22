using System;
namespace ultimaterace
{
    public class Scoreboard
    {
        #region Fields
        public int chopperdistancetotraveltowin = 7400;
        public int bikedistancetotraveltowin = 9800;
        public int tesladistancetotraveltowin = 10200;
        public int subdistancetotraveltowin = 11500;
        #endregion

        #region Contructor
        public Scoreboard()
        {
        }
        #endregion

        #region Properties
        public int truckposition { get; set; }

        public int chopperposition { get; set; }

        public int bikeposition { get; set; }

        public int lawnmowerposition { get; set; }

        public int teslapostion { get; set; }

        public int subposition { get; set; }
        #endregion
    }
}
