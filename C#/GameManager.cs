using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public bool _gameStatus;






        private void Awake()
        {
            if (instance == null) { instance = this; }
        }

        void Start()
        {
            _gameStatus = true;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
