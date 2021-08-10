using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ConMiss_USA_Alpha : IntefaceForMissions
    {
        public string ConMiss_USA_Alpha_MissionType = "Contract";
        public string MissionType { get { return ConMiss_USA_Alpha_MissionType; } }  // company or contracts



        public string ConMiss_USA_Alpha_MissionName = "USA Goverment: Project Alpha";
        public string MissionName { get { return ConMiss_USA_Alpha_MissionName; } }


        public string ConMiss_USA_Alpha_MissionDescription = "Secret project of CIA & NASA. DO NOT TALK.";
        public string MissionDescription { get { return ConMiss_USA_Alpha_MissionDescription; } }



        public float ConMiss_USA_Alpha_MinAltitude = 115f;
        public float MinAltitude { get { return ConMiss_USA_Alpha_MinAltitude; } }



        public float ConMiss_USA_Alpha_MaxAltitude = 125f;
        public float MaxAltitude { get { return ConMiss_USA_Alpha_MaxAltitude; } }



        public float ConMiss_USA_Alpha_MissionTimer = 15f;
        public float MissionTimer { get { return ConMiss_USA_Alpha_MissionTimer; } }



        public int ConMiss_USA_Alpha_MissionReward = 862500;
        public int MissionReward { get { return ConMiss_USA_Alpha_MissionReward; } }



        public int ConMiss_USA_Alpha_MassCargo = 750000;
        public float MassCargo { get { return ConMiss_USA_Alpha_MassCargo; } }
    }
}
