using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ConMiss_NASA_SaturnN : IntefaceForMissions
    {
        public string _MissionType = "Contract";
        public string MissionType { get { return _MissionType; } }  // company or contracts



        public string _MissionName = "NASA : Saturn Neighbour";
        public string MissionName { get { return _MissionName; } }


        public string _MissionDescription = "Nasa has discovered water on Saturn. Need to check for life on planet.";
        public string MissionDescription { get { return _MissionDescription; } }



        public float _MinAltitude = 130f;
        public float MinAltitude { get { return _MinAltitude; } }



        public float _MaxAltitude = 140f;
        public float MaxAltitude { get { return _MaxAltitude; } }



        public float _MissionTimer = 13f;
        public float MissionTimer { get { return _MissionTimer; } }



        public int _MissionReward = 1104000;
        public int MissionReward { get { return _MissionReward; } }



        public int _MassCargo = 960000;
        public float MassCargo { get { return _MassCargo; } }
    }
}
