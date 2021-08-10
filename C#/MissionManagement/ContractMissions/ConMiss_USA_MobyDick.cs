using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ConMiss_USA_MobyDick : IntefaceForMissions
    {
        public string _MissionType = "Contract";
        public string MissionType { get { return _MissionType; } }  // company or contracts



        public string _MissionName = "USA Goverment: Moby Dick";
        public string MissionName { get { return _MissionName; } }


        public string _MissionDescription = "National project for tracking wild animals in deep ocean.";
        public string MissionDescription { get { return _MissionDescription; } }



        public float _MinAltitude = 115f;
        public float MinAltitude { get { return _MinAltitude; } }



        public float _MaxAltitude = 125f;
        public float MaxAltitude { get { return _MaxAltitude; } }



        public float _MissionTimer = 15f;
        public float MissionTimer { get { return _MissionTimer; } }



        public int _MissionReward = 632500;
        public int MissionReward { get { return _MissionReward; } }



        public int _MassCargo = 550000;
        public float MassCargo { get { return _MassCargo; } }
    }
}
