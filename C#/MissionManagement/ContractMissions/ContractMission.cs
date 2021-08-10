using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ContractMission : IntefaceForMissions
    {
        
        public string MissionType { get; }  // company or contracts

        public string MissionName { get; }

        public string MissionDescription { get; }

        public float MinAltitude { get; }

        public float MaxAltitude { get; }

        public float MissionTimer { get; }

        public int MissionReward { get; }

        public float MassCargo { get; }



    }
}
