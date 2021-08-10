using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ConMiss_NASA_JungleS : IntefaceForMissions
    {
        public string _MissionType = "Contract";
        public string MissionType { get { return _MissionType; } }  // company or contracts



        public string _MissionName = "NASA : Jungle Science";
        public string MissionName { get { return _MissionName; } }


        public string _MissionDescription = "New technology for scanning life in jungle.";
        public string MissionDescription { get { return _MissionDescription; } }



        public float _MinAltitude = 110f;
        public float MinAltitude { get { return _MinAltitude; } }



        public float _MaxAltitude = 120f;
        public float MaxAltitude { get { return _MaxAltitude; } }



        public float _MissionTimer = 12f;
        public float MissionTimer { get { return _MissionTimer; } }



        public int _MissionReward = 971750;
        public int MissionReward { get { return _MissionReward; } }



        public int _MassCargo = 845000;
        public float MassCargo { get { return _MassCargo; } }
    }
}
