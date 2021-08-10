using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ConMiss_NASA_ExoMars : IntefaceForMissions
    {
        public string _MissionType = "Contract";
        public string MissionType { get { return _MissionType; } }  // company or contracts



        public string _MissionName = "NASA : Exo Mars";
        public string MissionName { get { return _MissionName; } }


        public string _MissionDescription = "Preparation planet before first humans on it.";
        public string MissionDescription { get { return _MissionDescription; } }



        public float _MinAltitude = 101f;
        public float MinAltitude { get { return _MinAltitude; } }



        public float _MaxAltitude = 115f;
        public float MaxAltitude { get { return _MaxAltitude; } }



        public float _MissionTimer = 10f;
        public float MissionTimer { get { return _MissionTimer; } }



        public int _MissionReward = 115000;
        public int MissionReward { get { return _MissionReward; } }



        public int _MassCargo = 100000;
        public float MassCargo { get { return _MassCargo; } }
    }
}
