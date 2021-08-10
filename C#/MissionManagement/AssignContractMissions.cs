using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CommercialSpace
{
    public static class AssignContractMissions 
    {
        public static List<IntefaceForMissions> LisOfclasses = new List<IntefaceForMissions>();
        public static IntefaceForMissions i_Dildo = new ConMiss_Dildo();
        public static IntefaceForMissions i_Green_EBF = new ConMiss_Green_EBF();
        public static IntefaceForMissions i_NASA_AsteroidH = new ConMiss_NASA_AsteroidH();
        public static IntefaceForMissions i_NASA_Diamond = new ConMiss_NASA_Diamond();
        public static IntefaceForMissions i_NASA_EarthOTT = new ConMiss_NASA_EarthOTT();
        public static IntefaceForMissions i_NASA_ExoMars = new ConMiss_NASA_ExoMars();
        public static IntefaceForMissions i_NASA_JungleS = new ConMiss_NASA_JungleS();
        public static IntefaceForMissions i_NASA_SaturnN = new ConMiss_NASA_JungleS();
        public static IntefaceForMissions i_Rus_BalalaykaT = new ConMiss_Rus_BalalaykaT();
        public static IntefaceForMissions i_Rus_Batut = new ConMiss_Rus_Batut();
        public static IntefaceForMissions i_Rus_PStatue = new ConMiss_Rus_PStatue();
        public static IntefaceForMissions i_Rus_RedPioner = new ConMiss_Rus_RedPioner();
        public static IntefaceForMissions i_Rus_RedSky = new ConMiss_Rus_RedSky();
        public static IntefaceForMissions i_USA_AirFO = new ConMiss_USA_AirFO();
        public static IntefaceForMissions i_USA_Alpha = new ConMiss_USA_Alpha();
        public static IntefaceForMissions i_USA_Democracy = new ConMiss_USA_Democracy();
        public static IntefaceForMissions i_USA_EScout = new ConMiss_USA_EScout();
        public static IntefaceForMissions i_USA_MobyDick = new ConMiss_USA_MobyDick();
        public static IntefaceForMissions i_USA_SM = new ConMiss_USA_SM();
        public static IntefaceForMissions i_USAJD = new ConMiss_USAJD();


        private static float _RequirementEnginePower_1 = 700;      //not balanced !! !!
        private static float _RequirementEnginePower_2 = 1200;      //not balanced !! !!
        private static float _RequirementEnginePower_3 = 2000;      //not balanced !! !!
        public static void AssignClassByLvlToList()
        {
            

            if (Movement.instance.MainThrust < _RequirementEnginePower_1)
            {
                ListMissions_Easy_LVL();
            }
            if (Movement.instance.MainThrust < _RequirementEnginePower_2)
            {
                ListMissions_Middle_LVL();
            }
            if (Movement.instance.MainThrust < _RequirementEnginePower_3)
            {
                ListMissions_Hard_LVL();
            }

        }
        private static void ListMissions_Easy_LVL()
        {
            LisOfclasses.Add(i_Dildo);
            LisOfclasses.Add(i_USA_SM);
            LisOfclasses.Add(i_USA_EScout);
            LisOfclasses.Add(i_NASA_ExoMars);
            LisOfclasses.Add(i_NASA_AsteroidH);
            LisOfclasses.Add(i_Rus_Batut);
            LisOfclasses.Add(i_Rus_PStatue);
            LisOfclasses.Add(i_Rus_RedPioner);
            LisOfclasses.Add(i_Green_EBF);
            LisOfclasses.Add(i_Green_EBF);

        }
        private static void ListMissions_Middle_LVL()
        {
            LisOfclasses.Add(i_USA_Alpha);
            LisOfclasses.Add(i_USA_MobyDick);
            LisOfclasses.Add(i_NASA_Diamond);
            LisOfclasses.Add(i_NASA_SaturnN);
            LisOfclasses.Add(i_NASA_JungleS);
            LisOfclasses.Add(i_Rus_RedSky);
            LisOfclasses.Add(i_Rus_BalalaykaT);
            LisOfclasses.Add(i_Rus_BalalaykaT);
        }
        private static void ListMissions_Hard_LVL()
        {
            LisOfclasses.Add(i_USAJD);
            LisOfclasses.Add(i_USA_AirFO);
            LisOfclasses.Add(i_USA_Democracy);
            LisOfclasses.Add(i_NASA_EarthOTT);
            LisOfclasses.Add(i_NASA_EarthOTT);
        }


    }
}
