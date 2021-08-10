using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class PlayerPosition : MonoBehaviour
    {
        public float _rocketPosY;

        public static PlayerPosition instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }

        }

        void Update()
        {
            _rocketPosY = transform.position.y;
        }
    }
}
