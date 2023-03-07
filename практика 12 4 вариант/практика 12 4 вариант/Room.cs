using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_12_4_вариант
{
    class Room
    {
        public double l;
        public double sh;
        //private double S;
        //private double V;
        public double H;
        public int kolv_windows;

        public void Set_S()
        {
           double S = l * sh;
        }
        public double Get_S()
        {
            double S = l * sh;
            return S;
        }

        public void Set_V()
        {
           double  V = l * sh*H;
        }
        public double Get_V()
        {
            double V = l * sh * H;
            return V;
        }

        public Room(double l,double sh,double H,int kolv_windows)
        {
            this.l = l;
            this.sh = sh;
            this.H = H;
            this.kolv_windows = kolv_windows;
        }

        public Room()
        {

        }
    }
}
