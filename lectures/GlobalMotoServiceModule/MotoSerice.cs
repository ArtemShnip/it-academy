using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalMotoServiceModule
{
    //public delegate void MotoServiceDelegate(int totalDistance);
    public class MotoSerice
    {
        //public static int TotalDistance { get; set; }
        //private MotoServiceDelegate _motoServiceDelegate;
        private Action<int> _motoServiceDelegate;
        public static int DistanceFromLastService { get; set; }

        public MotoSerice()
        {
            CheckDistance();
        }

        //public MotoSerice(MotoServiceDelegate motoServiceDelegate)
        //{
        //    _motoServiceDelegate = motoServiceDelegate;
        //    CheckDistance();
        //}

        public MotoSerice(Action<int> motoServiceDelegate)
        {
            _motoServiceDelegate = motoServiceDelegate;
            CheckDistance();
        }

        void CheckDistance()
        {
            if (DistanceFromLastService >= 9_800)
            {
                //Notify
                NotifyAboutSerivice();
            }
        }

        void NotifyAboutSerivice()
        {
            if (_motoServiceDelegate == null) return;
            
            _motoServiceDelegate(DistanceFromLastService);
            ResetDistance();
           // _motoServiceDelegate?.Invoke(DistanceFromLastService);
            Console.WriteLine("\nNotifyAboutSerivice\n");
                    
            
        }

        void ResetDistance()
        {
            DistanceFromLastService = 0;
        }
    }
}
