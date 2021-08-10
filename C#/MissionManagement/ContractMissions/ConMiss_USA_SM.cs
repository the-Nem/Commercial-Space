using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ConMiss_USA_SM : IntefaceForMissions
    {
        public string _MissionType = "Contract";
        public string MissionType { get { return _MissionType; } }  // company or contracts



        public string _MissionName = "USA Goverment: Space Marine";
        public string MissionName { get { return _MissionName; } }


        public string _MissionDescription = "Unofficially, military base workers in orbit. No one knows about it.";
        public string MissionDescription { get { return _MissionDescription; } }



        public float _MinAltitude = 105f;
        public float MinAltitude { get { return _MinAltitude; } }



        public float _MaxAltitude = 120f;
        public float MaxAltitude { get { return _MaxAltitude; } }



        public float _MissionTimer = 10f;
        public float MissionTimer { get { return _MissionTimer; } }



        public int _MissionReward =  172500;
        public int MissionReward { get { return _MissionReward; } }



        public int _MassCargo =  150000;
        public float MassCargo { get { return _MassCargo; } }
    }
}
