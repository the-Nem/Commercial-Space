using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class LandingSolesCollider : MonoBehaviour
    {

        //private void OnCollisionEnter(UnityEngine.Collision collision)
        //{
        //    //switch (collision.gameObject.tag)
        //    //{
        //    //    case "Finish":
        //    //        SuccessfullyFinishedLVL();
        //    //        break;
        //    //    case "Friendly":
                    
        //    //        break;
        //    //    default:
        //    //        //MethodDead();
        //    //        break;
        //    //}

        //    if(collision.gameObject.tag== "Finish")
        //    {
        //        Debug.Log("yec bich");
        //        SuccessfullyFinishedLVL();
        //    }

        //}
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Finish")
            {
                Debug.Log("yec bich");
                SuccessfullyFinishedLVL();
            }
        }

        private void SuccessfullyFinishedLVL()
        {
            UI_Panels.instance.SequinceWinLvl();
            Debug.Log("Sc LandingSolesCollider SuccessfullyFinishedLVL");

        }
        private void MethodDead()
        {
            UI_Panels.instance.PanelLooseGame.SetActive(true);
            Debug.Log("Sc LandingSolesCollider MethodDead");


        }
    }
}
