using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class AnimationController : MonoBehaviour
    {
        public static AnimationController instance;

        public Animation Leg_LeftFront;

        private void Awake()
        {
            if (instance == null) { instance = this; }
        }
        //public Animation LegsOpen2;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //if (Input.GetKeyDown(KeyCode.O)) { StartAnimation(); }
        }
        public void StartAnimation()
        {
            Leg_LeftFront.Play();
            //LegsOpen2.Play();

        }
    }
}
