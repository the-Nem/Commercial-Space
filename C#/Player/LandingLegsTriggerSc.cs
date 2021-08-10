using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class LandingLegsTriggerSc : MonoBehaviour
    {
        private float _minLandingSpeed = 4;
        public GameObject Soles1;
        public GameObject Soles2;
        public GameObject Soles3;
        public GameObject Soles4;
        Rigidbody rb;
        private void OnTriggerEnter(Collider other)
        {
            switch (other.gameObject.tag)
            {
                case "Finish":
                    SequinceLanding();
                    break;
                case "MissionPoint":
                    SequinceMissionPoint();
                    break;
                default:
                    break;
            }
        }


        private void SequinceLanding()
        {
            if (PlObjSpeedometer.instance.speed < _minLandingSpeed)
            {
                //animation landing legs
                AnimationController.instance.StartAnimation();
                Debug.Log("Sc LandingLegsTriggerSc SequinceLanding");
               
            }
        }
        private void SequinceMissionPoint()
        {
            if (PlObjSpeedometer.instance.speed < _minLandingSpeed)
            {
                //animation landing legs
                AnimationController.instance.StartAnimation();
               // Debug.Log("Sc LandingLegsTriggerSc SequinceMissionPoint");

            }
        }
        
    }
}
