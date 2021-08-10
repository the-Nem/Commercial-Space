using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ConMiss_Rus_PStatue : IntefaceForMissions
    {
        public string _MissionType = "Contract";
        public string MissionType { get { return _MissionType; } }  // company or contracts



        public string _MissionName = "Russia Goverment : P. Statue";
        public string MissionName { get { return _MissionName; } }


        public string _MissionDescription = "One animus rich man wants to send his statue to atmosphere.";
        public string MissionDescription { get { return _MissionDescription; } }



        public float _MinAltitude = 120f;
        public float MinAltitude { get { return _MinAltitude; } }



        public float _MaxAltitude = 125f;
        public float MaxAltitude { get { return _MaxAltitude; } }



        public float _MissionTimer = 10f;
        public float MissionTimer { get { return _MissionTimer; } }



        public int _MissionReward = 271055;
        public int MissionReward { get { return _MissionReward; } }



        public int _MassCargo = 235700;
        public float MassCargo { get { return _MassCargo; } }
    }
}
