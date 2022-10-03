using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork10
{
    internal class Circle
    {
        
        double gradus;
        double min;
        double sec;
        public bool isCorrect=true;
        public double Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                gradus = value % 360;
            }
        }

        public double Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Gradus += value / 60;
                    min = value % 60;
                }
            }
        }
        public double Sec
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Min += value / 60;
                    sec = value % 60;
                }
            }
        }
        public Circle(double gradus,  double min,  double sec)
        {
            
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
            
        }
        public double ToRadians() 
        {
            return ((sec + min * 60 + gradus * 60 * 60)/3600) * Math.PI / 180;
        }

    }
}
