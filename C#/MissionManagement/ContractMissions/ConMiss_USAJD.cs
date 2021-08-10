using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ConMiss_USAJD : IntefaceForMissions
    {
        public string ConMiss_USAJD_MissionType = "Contract";
        public string MissionType { get { return ConMiss_USAJD_MissionType; } }  // company or contracts



        public string ConMiss_USAJD_MissionName = "USA Goverment: Judgmant Day";
        public string MissionName { get { return ConMiss_USAJD_MissionName; } }


        public string ConMiss_USAJD_MissionDescription = "Secret project of White House. Classified.";
        public string MissionDescription { get { return ConMiss_USAJD_MissionDescription; } }



        public float ConMiss_USAJD_MinAltitude = 120f;
        public float MinAltitude { get { return ConMiss_USAJD_MinAltitude; } }



        public float ConMiss_USAJD_MaxAltitude = 122f;
        public float MaxAltitude { get { return ConMiss_USAJD_MaxAltitude; } }



        public float ConMiss_USAJD_MissionTimer = 15f;
        public float MissionTimer { get { return ConMiss_USAJD_MissionTimer; } }



        public int ConMiss_USAJD_MissionReward =  2875000;
        public int MissionReward { get { return ConMiss_USAJD_MissionReward; } }



        public int ConMiss_USAJD_MassCargo =  2500000;
        public float MassCargo { get { return ConMiss_USAJD_MassCargo; } }
    }
}
