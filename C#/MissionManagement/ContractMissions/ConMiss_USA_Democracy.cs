using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ConMiss_USA_Democracy : IntefaceForMissions
    {
        public string _MissionType = "Contract";
        public string MissionType { get { return _MissionType; } }  // company or contracts



        public string _MissionName = "USA Goverment: Democracy statue";
        public string MissionName { get { return _MissionName; } }


        public string _MissionDescription = "Mark earth as democratic planet.";
        public string MissionDescription { get { return _MissionDescription; } }



        public float _MinAltitude = 116f;
        public float MinAltitude { get { return _MinAltitude; } }



        public float _MaxAltitude = 118f;
        public float MaxAltitude { get { return _MaxAltitude; } }



        public float _MissionTimer = 10f;
        public float MissionTimer { get { return _MissionTimer; } }



        public int _MissionReward = 3450000;
        public int MissionReward { get { return _MissionReward; } }



        public int _MassCargo = 3000000;
        public float MassCargo { get { return _MassCargo; } }
    }
}
