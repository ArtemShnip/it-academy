using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalMotoServiceModule
{
    public class MotoSerice
    {
        public static int TotalDistance { get; set; }
        
        public static int DistanceFromLastService { get; set; }

        public MotoSerice()
        {
            CheckDistance();
        }

        void CheckDistance()
        {
            if (TotalDistance >= 9_800)
            {
                //Notify
                NotifyAboutSerivice();
            }
        }

        void NotifyAboutSerivice()
        {
            //?
            ResetDistance();
        }

        void ResetDistance()
        {
            DistanceFromLastService = 0;
        }
    }
}
