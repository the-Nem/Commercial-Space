using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class MissionsDataBase 
    {
        public string MissionName;
        //public string MissionDescription;
        public string MissionType;  //send storage to space or passingers
        //public bool boolMissionType;  //do i need this

        public float MinAltitude;
        public float MaxAltitude;

        public float missionTimer;

        public int MissionReward;

        //каким то образом надо value которая показывает сколько груз места занимает

    }
}
