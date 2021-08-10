
using System;
using UnityEngine;
using UnityEngine.SceneManagement;



namespace CommercialSpace
{

    public class Collision : MonoBehaviour
    {
        public static Collision instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }
        }

        [SerializeField] float DeleyLoadLvl = 1f;


        //bool isTrans = false;
        bool CheatColl = false;

        void Start()
        {

        }
        private void Update()        
        {
            //CheatColliderOff();
        }
        private void CheatColliderOff()
        {
            if (Input.GetKeyDown(KeyCode.C)) { CheatColl = !CheatColl; }
        }

        private void OnCollisionEnter(UnityEngine.Collision collision)
        {
            //if (isTrans || CheatColl) { return; }
            if (CheatColl) { return; }

            switch (collision.gameObject.tag)
            {
                case "Friendly":
                    //this is only for standing on launching pad
                    Debug.Log("Sc collision friendy");
                    break;

                //case "Finish":
                //    StartSuccessSequence();

                //    break;

                ////case "Fuel":
                ////    Method3();
                ////    break;
                default:
                    DeadSequence();
                    Debug.Log("Sc collision DeadSequence");

                    break;
            }
        }


        private void StartSuccessSequence()
        {
            // rat Sys fire work near Landing pad
            //play win sound



            // Panel Win Lvl set active
            UI_Panels.instance.PanelWinLvl.SetActive(true);


            // increase money

        }

        void SequenceForFriendlyObj()
        {
            Debug.Log("Friendly");
        }

  
        void DeadSequence()
        {
            GameManager.instance._gameStatus = false;
            // part sys big boom
            //stop lounge music
            //play sad sound



            UI_Panels.instance.PanelLooseGame.SetActive(true);
            //show game over panel

            //add feature Every crash -10% of deal. some times up to 50%.

            //button Try again
            // button quit current mission




        }
    }
}
