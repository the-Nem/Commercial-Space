using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




namespace CommercialSpace
{
    public class Ui : MonoBehaviour
    {
        public static Ui instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }
        }


        public void StartBut()
        {
            //Collision.instance.LoadFirstLvl();
        }
        public void BoostOnClickDown()
        {
            Movement.instance.Button__SpaceBoostBool = true;
            ParticleSys.instance.PartSys_MainEngine_ButtonDown();
            AudioBase.instance.MainBoostSound_ButtonDown();

        }
        public void BoostOnClickUp()
        {
            Movement.instance.Button__SpaceBoostBool = false;
            ParticleSys.instance.PartSys_MainEngine_ButtonUp();
            AudioBase.instance.MainBoostSound_ButtonUp();

        }

        public void LeftOnClickDown()
        {
            Movement.instance.Button__LeftButbool = true;
            ParticleSys.instance.PartSys_RightBooster_ButtonDown();

            //Debug.Log("L-D");
        }
        public void LeftOnClickUp()
        {
            Movement.instance.Button__LeftButbool = false;
            ParticleSys.instance.PartSys_RightBooster_ButtonUP();

            //Debug.Log("L-u");
        }
        public void RightOnClickDown()
        {
            Movement.instance.Button__RightButbool = true;
            ParticleSys.instance.PartSys_LeftBooster_ButtonDown();

            //Debug.Log("R-D");
        }
        public void RightOnClickUp()
        {
            Movement.instance.Button__RightButbool = false;
            ParticleSys.instance.PartSys_LeftBooster_ButtonUP();

           // Debug.Log("R-u");
        }


    }
}
