using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

namespace CommercialSpace
{

    public class The_Score : MonoBehaviour
    {

        public static The_Score instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }
            DontDestroyOnLoad(gameObject);
        }
        private int realCoin = 0;

        public int Coin_score_MAIN
        {
            get { return realCoin; }
            set
            {
                //if (value>800) { GameManager.gameStatus = false; return; }
                //else { realCoin = value; }

                realCoin = value;
            }
        }



       

        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void CoinCalculation(int value) { Coin_score_MAIN += value; }  //Saver.instance.jsonCandyScore += candy; Saver.instance.Save();
        public void DoubleCoinCalculation()
        {
            Coin_score_MAIN = Coin_score_MAIN * 2;

        }
        public void HowMuchMoneyYouHave()
        {

            MissionPanelElements.instance.Text_SummBuget.text = Coin_score_MAIN.ToString();
        }
    }
}
