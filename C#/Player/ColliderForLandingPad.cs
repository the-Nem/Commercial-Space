using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class ColliderForLandingPad : MonoBehaviour
    {
        private void OnCollisionEnter(UnityEngine.Collision collision)
        {
            if(collision.gameObject.tag=="Soles")
            {
                SuccessfullyFinishedLVL();
            }
        }
        private void SuccessfullyFinishedLVL()
        {
            UI_Panels.instance.PanelWinLvl.SetActive(true);
            Debug.Log("Sc LandingSolesCollider SuccessfullyFinishedLVL");

        }
    }
}
