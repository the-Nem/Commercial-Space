using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace CommercialSpace 
{
    public class UI_Panels : MonoBehaviour
    {
        public GameObject PanelGamePlay;
        public GameObject Panel_GlobalTutorial;
        public GameObject Panel_ControlsTutorial;
        public GameObject PanelMission_1;

        private int _indexCurrentLVL;


        public TMP_Text ShowMissionTimerText;
        public GameObject MissionTimerGObj;
        public TMP_Text Text_MissionWhatToDo;


        public GameObject PanelWinLvl;
        public GameObject PanelLooseGame;
        public GameObject Panel_ChooseMission;




        public TMP_Text ZZ__DELETE;


        public static UI_Panels instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }
            GetCurrentLvlIndex();
            AssignPanelsForMission_1();
        }

        void Start()
        {
            CurrentLvlToSwitch();
        }


        void Update()
        {
            ZZ__DELETE.text = PlObjSpeedometer.instance.speed.ToString();

        }
        private void GetCurrentLvlIndex()
        {
            _indexCurrentLVL = SceneManager.GetActiveScene().buildIndex;
        }
        private void CurrentLvlToSwitch()
        {
            switch (_indexCurrentLVL)
            {
                case 0:
                    PanelsForMainMenu();

                    break;
                case 1:
                    PanelsForLvl1();
                    break;
                case 2:

                    break;

                default:
                    break;
            }
        }
        private void PanelsForMainMenu()
        {

        }
        private void PanelsForLvl1()
        {
            PanelGamePlay.SetActive(true);
            Panel_GlobalTutorial.SetActive(true);
            Panel_ControlsTutorial.SetActive(false);
            PanelMission_1.SetActive(false);

        }
        private void AssignPanelsForMission_1()
        {
            MissionTimerGObj = GameObject.Find("MissionTimerGObj");
            ShowMissionTimerText = GameObject.Find("Text_MissionTimer").GetComponent<TMP_Text>();
            Text_MissionWhatToDo = GameObject.Find("Text_MissionWhatToDo").GetComponent<TMP_Text>();
            MissionTimerGObj.SetActive(false);
            PanelWinLvl.SetActive(false);

        }
        public void SequinceWinLvl()
        {
            PanelGamePlay.SetActive(false);
            Panel_GlobalTutorial.SetActive(false);
            Panel_ControlsTutorial.SetActive(false);
            PanelMission_1.SetActive(false);
            PanelWinLvl.SetActive(true);

        }
    }
}
