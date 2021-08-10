using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CommercialSpace
{
    public class Mission_1 : MonoBehaviour
    {

        private bool boolStage_1_Finished;

        //public float _rocketPosY;   // create special Sc only for PlObj data & import
        private int _MissionStage;



        private float _minHeigth = 100f;
        private float _maxHeigth = 120f;
        private float _missionTimer = 10f;



        private void Awake()
        {
           
        }


        void Start()
        {

        }


        void Update()
        {
          
            CheckRocketAltitude_Switch();
            MissionStages();

        }
        private void MissionStages()
        {
            switch (_MissionStage)
            {
                case 1:
                    Stage1Work();
                    break;
                case 2:
                    Stage2Work();
                    break;
                case 3:
                    Stage3Work();
                    break;
                default:
                    DefaultStage();
                    break;
            }
        }


        private void Stage1Work()
        {
            _missionTimer = 10f;
            UI_Panels.instance.MissionTimerGObj.SetActive(false);
            UI_Panels.instance.Text_MissionWhatToDo.text = MissionStageString.TextStage1;
        }

        private void CheckRocketAltitude_Switch()
        {
            if (boolStage_1_Finished==true) { return; }
            if (PlayerPosition.instance._rocketPosY > _minHeigth && PlayerPosition.instance._rocketPosY < _maxHeigth)
            {
                _MissionStage = 2;
            }
            //else if (_rocketPosY < _minHeigth && _rocketPosY > _maxHeigth)
            else 
            {
                _MissionStage = 1;
            }
        }
        private void Stage2Work()
        {
            UI_Panels.instance.MissionTimerGObj.SetActive(true);
            UI_Panels.instance.ShowMissionTimerText.text = _missionTimer.ToString();
            UI_Panels.instance.Text_MissionWhatToDo.text = MissionStageString.TextStage2;

            CounterMethod();
        }

        private void CounterMethod()
        {
            _missionTimer -= Time.deltaTime;
            int _floatToInt = (int)_missionTimer;
            UI_Panels.instance.ShowMissionTimerText.text = _floatToInt.ToString();
            if (_missionTimer <= 0)
            {
                _MissionStage = 3;
                boolStage_1_Finished = true;
            }
        }
        private void Stage3Work()
        {
            UI_Panels.instance.ShowMissionTimerText.text = "ok";
            UI_Panels.instance.Text_MissionWhatToDo.text = MissionStageString.TextStage3;
        }
        private void DefaultStage()
        {
            _missionTimer = 10f;
            UI_Panels.instance.MissionTimerGObj.SetActive(false);
        }
    }
}
