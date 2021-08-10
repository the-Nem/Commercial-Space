using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ConMiss_1 : IntefaceForMissions
    {
        public string ConMiss_1MissionType = "Contract";
        public string MissionType { get; }  // company or contracts



        public string ConMiss_1MissionName = "Dildo in space";
        public string MissionName { get; }


        public string ConMiss_1MissionDescription = "Deliver statue of dick to space ";
        public string MissionDescription { get; }



        public float ConMiss_1MinAltitude = 110f;
        public float MinAltitude { get; }



        public float ConMiss_1MaxAltitude = 120f;
        public float MaxAltitude { get; }



        public float ConMiss_1MissionTimer = 10f;
        public float MissionTimer { get; }



        public int ConMiss_1MissionReward = 1000000;
        public int MissionReward { get; }



        public int ConMiss_1MassCargo = 1000000;
        public float MassCargo { get; }
    }
}
