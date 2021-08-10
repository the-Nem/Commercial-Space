using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class GodSWill : MonoBehaviour
    {
        private List<string> Lvl1_obj = new List<string>();
        private List<Vector3> Lvl1_pos = new List<Vector3>();


        private string GroundPack_1 = "GroundPack_1";
        Vector3 PosGroundPack_1 = new Vector3(0, 0, 0);

        private void Awake()
        {
            AssignObj();
            AssignPossition();
            AngelWork();
        }

        private void AssignObj()
        {
            Lvl1_obj.Add("Finish");
            Lvl1_obj.Add("GroundPack_1");
            Lvl1_obj.Add("LaunchPad_PAPA");
            Lvl1_obj.Add("RocketPapa");
            Lvl1_obj.Add("Clouds");

        }
        private void AssignPossition()
        {
            Lvl1_pos.Add(new Vector3(26.15f,0.45f,0));
            Lvl1_pos.Add(new Vector3(15.37f,2,0.305f));
            Lvl1_pos.Add(new Vector3(0.86f,5.54f,9.36f));
            Lvl1_pos.Add(new Vector3(0,2.639f,0));
            Lvl1_pos.Add(new Vector3(20,-3,9.5f));

        }

        private void AngelWork()
        {
            //Infinity.Commandment(GroundPack_1, PosGroundPack_1);

            Infinity.Commandment(Lvl1_obj[0], Lvl1_pos[0]);
            Infinity.Commandment(Lvl1_obj[1], Lvl1_pos[1]);
            Infinity.Commandment(Lvl1_obj[2], Lvl1_pos[2]);
            Infinity.Commandment(Lvl1_obj[3], Lvl1_pos[3]);
            Infinity.Commandment(Lvl1_obj[4], Lvl1_pos[4]);




            //foreach (var item in Lvl1_obj)      //  !! not working, wpanin main menu
            //{
            //    int count = 0;
            //    Infinity.Commandment(item, Lvl1_pos[count]);
            //    count++;

            //    //Infinity.Commandment(item, new Vector3(0,0,0));

            //}


        }
    }
}
