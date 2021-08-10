using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{

    public class ParticleSys : MonoBehaviour
    {
        public static ParticleSys instance;


        [SerializeField] ParticleSystem SuccessPartSys;
        [SerializeField] ParticleSystem CrashPartSys;

        [SerializeField] ParticleSystem MainBoost;
        [SerializeField] ParticleSystem BoostWhileOnPlato;

        [SerializeField] ParticleSystem RightBooster;
        [SerializeField] ParticleSystem LeftBooster;



        private void Awake()
        {
            if (instance == null) { instance = this; }
        }
        void Start()
        {
            PartSys_OnStart();
        }


        void Update()
        {
        
        }
        public void PlayPS_Success() 
        {
            SuccessPartSys.Play();
        }        
        public void PlayPS_Crash() 
        {

        }        
        private void PartSys_OnStart() { BoostWhileOnPlato.Play(); }
        public void PartSys_MainEngine_ButtonDown() 
        {
            if (BoostWhileOnPlato.isPlaying) { BoostWhileOnPlato.Stop(); }
            MainBoost.Play();
        }
        public void PartSys_MainEngine_ButtonUp()
        {
            MainBoost.Stop();
        }
        public void PartSys_LeftBooster_ButtonDown()
        {
            LeftBooster.Play();
        }
        public void PartSys_LeftBooster_ButtonUP()
        {
            LeftBooster.Stop();
        }
        public void PartSys_RightBooster_ButtonDown() 
        {
            RightBooster.Play();
        }
        public void PartSys_RightBooster_ButtonUP()
        {
            RightBooster.Stop();
        }

    }
}
