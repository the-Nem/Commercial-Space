using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;

namespace CommercialSpace
{
    public class ZZZZ : MonoBehaviour
    {


        public static string _stringRandomMission;

        void Start()
        {
            AssignClassByLvlToList();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) { GenerateContractMission(); }
        }
        public static void GenerateContractMission()
        {
            var RandomMission = AssignContractMissions.LisOfclasses[ZZ2_string.ABC];

            Debug.Log("RandomMission = " + RandomMission);

            _stringRandomMission=RandomMission.ToString();

            Type type = typeof(IntefaceForMissions);
            MethodInfo info = type.GetMethod("MissionType");
            //info.Invoke(null, null);
  
            Debug.Log("info = " + info);
            


        }
        public static void AssignClassByLvlToList()
        {
            AssignContractMissions.LisOfclasses.Add(AssignContractMissions.i_Dildo);
            AssignContractMissions.LisOfclasses.Add(AssignContractMissions.i_USA_SM);
            AssignContractMissions.LisOfclasses.Add(AssignContractMissions.i_USA_EScout);
            AssignContractMissions.LisOfclasses.Add(AssignContractMissions.i_NASA_ExoMars);
            AssignContractMissions.LisOfclasses.Add(AssignContractMissions.i_NASA_AsteroidH);
            AssignContractMissions.LisOfclasses.Add(AssignContractMissions.i_Rus_Batut);
            AssignContractMissions.LisOfclasses.Add(AssignContractMissions.i_Rus_PStatue);
            AssignContractMissions.LisOfclasses.Add(AssignContractMissions.i_Rus_RedPioner);
            AssignContractMissions.LisOfclasses.Add(AssignContractMissions.i_Green_EBF);
            AssignContractMissions.LisOfclasses.Add(AssignContractMissions.i_Green_EBF);
        }
    }
}
