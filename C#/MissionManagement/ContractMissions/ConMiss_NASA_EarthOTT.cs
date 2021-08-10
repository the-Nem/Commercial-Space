using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ConMiss_NASA_EarthOTT : IntefaceForMissions
    {
        public string _MissionType = "Contract";
        public string MissionType { get { return _MissionType; } }  // company or contracts



        public string _MissionName = "NASA : Earth Observing Terrace Telescope";
        public string MissionName { get { return _MissionName; } }


        public string _MissionDescription = "Small platform for new technology.";
        public string MissionDescription { get { return _MissionDescription; } }



        public float _MinAltitude = 101f;
        public float MinAltitude { get { return _MinAltitude; } }



        public float _MaxAltitude = 105f;
        public float MaxAltitude { get { return _MaxAltitude; } }



        public float _MissionTimer = 13f;
        public float MissionTimer { get { return _MissionTimer; } }



        public int _MissionReward = 1265000;
        public int MissionReward { get { return _MissionReward; } }



        public int _MassCargo = 1100000;
        public float MassCargo { get { return _MassCargo; } }
    }
}
