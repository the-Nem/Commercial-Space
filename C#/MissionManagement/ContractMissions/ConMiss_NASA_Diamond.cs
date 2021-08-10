using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ConMiss_NASA_Diamond : IntefaceForMissions
    {
        public string _MissionType = "Contract";
        public string MissionType { get { return _MissionType; } }  // company or contracts



        public string _MissionName = "NASA : Diamond telescope";
        public string MissionName { get { return _MissionName; } }


        public string _MissionDescription = "Nasas new generation of orbit telescope. Used to discover backs of space.";
        public string MissionDescription { get { return _MissionDescription; } }



        public float _MinAltitude = 120f;
        public float MinAltitude { get { return _MinAltitude; } }



        public float _MaxAltitude = 130f;
        public float MaxAltitude { get { return _MaxAltitude; } }



        public float _MissionTimer = 10f;
        public float MissionTimer { get { return _MissionTimer; } }



        public int _MissionReward = 713345;
        public int MissionReward { get { return _MissionReward; } }



        public int _MassCargo = 620300;
        public float MassCargo { get { return _MassCargo; } }
    }
}
