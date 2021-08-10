using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace
{
    public class AudioBase : MonoBehaviour
    {
        public static AudioBase instance;

        [SerializeField] AudioSource WarmigUpEngine;
        [SerializeField] AudioSource MainEngineBoost;
        //[SerializeField] AudioClip mainEngine;



        private void Awake()
        {
            if (instance == null) { instance = this; }
        }

        void Start()
        {
            OnStartWarmigUpEngine();
        }


        void Update()
        {
            
        
        }
        private void OnStartWarmigUpEngine()
        {
            WarmigUpEngine.Play();
            //WarmigUpEngine.Play(mainEngine);  //not working
        }
        public void MainBoostSound_ButtonDown()
        {
            //if (WarmigUpEngine.isPlaying) { WarmigUpEngine.Stop(); }
            WarmigUpEngine.Stop();
            MainEngineBoost.Play();
        }
        public void MainBoostSound_ButtonUp()
        {
            MainEngineBoost.Stop();
        }
    }
}
