using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ConMiss_Rus_RedPioner : IntefaceForMissions
    {
        public string _MissionType = "Contract";
        public string MissionType { get { return _MissionType; } }  // company or contracts



        public string _MissionName = "Russia Goverment : Red Pioner";
        public string MissionName { get { return _MissionName; } }


        public string _MissionDescription = "Secret project of KGB. Classified.";
        public string MissionDescription { get { return _MissionDescription; } }



        public float _MinAltitude = 120f;
        public float MinAltitude { get { return _MinAltitude; } }



        public float _MaxAltitude = 130f;
        public float MaxAltitude { get { return _MaxAltitude; } }



        public float _MissionTimer = 10f;
        public float MissionTimer { get { return _MissionTimer; } }



        public int _MissionReward = 529000;
        public int MissionReward { get { return _MissionReward; } }



        public int _MassCargo = 460000;
        public float MassCargo { get { return _MassCargo; } }
    }
}
