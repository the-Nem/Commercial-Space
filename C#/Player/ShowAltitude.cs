using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace CommercialSpace
{
    
    public class ShowAltitude : MonoBehaviour
    {
        private TMP_Text ShowAltitudeText;



        private void Awake()
        {

            AssignObjAltitude();

        }
        private void AssignObjAltitude()
        {
            ShowAltitudeText = GameObject.Find("Text_Alditute").GetComponent<TMP_Text>();

        }

        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            float _height = (int)transform.position.y;
            ShowAltitudeText.text = _height.ToString();
        }
    }
}
