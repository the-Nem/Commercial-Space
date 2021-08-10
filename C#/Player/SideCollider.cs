using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class SideCollider : MonoBehaviour
    {
        private void OnCollisionEnter(UnityEngine.Collision collision)
        {
            DeadSequence();
            Debug.Log("Sc collision DeadSequence");
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
