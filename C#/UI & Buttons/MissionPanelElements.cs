using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace CommercialSpace
{
    
    public class MissionPanelElements : MonoBehaviour
    {
        public GameObject PanelMissionsContractsALL;
        public GameObject PanelMissionsContracts_1;
        public TMP_Text TextMissionName;
        public TMP_Text TextMissionDescription;

        public TMP_Text MinAltitude;    //
        public TMP_Text MaxAltitude;    //
        public TMP_Text MissionTimer;   //
        public TMP_Text MissionReward;  //
        public TMP_Text MassCargo;

        public TMP_Text Text_ComplitedMissionReward;
        public TMP_Text Text_SummBuget;



        public static MissionPanelElements instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }
        }

        void Start()
        {
        
        }


        void Update()
        {
        
        }
        public void SequinceWinLvl()
        {

        }
    }
}
