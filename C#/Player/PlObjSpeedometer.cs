using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class PlObjSpeedometer : MonoBehaviour
    {
        public float speed;

        public static PlObjSpeedometer instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }
            
        }
        void Start()
        {
            StartCoroutine(CalcSpeed());
        }
        private void Update()
        {
            //Debug.Log("Speed = " + speed);
        }
        IEnumerator CalcSpeed()
        {
            bool isPlaying = true;

            while (isPlaying)
            {
                Vector3 prevPos = transform.position;

                yield return new WaitForFixedUpdate();

                speed = Mathf.RoundToInt(Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime);
            }
        }
    }
}
