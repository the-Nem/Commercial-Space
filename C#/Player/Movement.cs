using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CommercialSpace
{
    public class Movement : MonoBehaviour
    {
        public static Movement instance;
        Rigidbody rb;

        [Header("Header 01")]
        [Tooltip("description of values")]
        private float _secretMainThrust = 600;
        public float MainThrust { get { return _secretMainThrust; } set { if (value > 1000) { return; } _secretMainThrust += value; } }

        [SerializeField] float MainRotate = 150f;



        //[SerializeField] AudioClip mainEngine;
         //AudioSource AudioSource;


        //[SerializeField] ParticleSystem MainBoost;
        //[SerializeField] ParticleSystem BoostWhileOnPlato;
        //[SerializeField] ParticleSystem LeftBoost;
        //[SerializeField] ParticleSystem RightBooster;

        public bool Button__SpaceBoostBool = false;
        public bool Button__LeftButbool = false;
        public bool Button__RightButbool = false;

        private void Awake()
        {
            if (instance == null) { instance = this; }
        }
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            //AudioSource = GetComponent<AudioSource>();
        }

        void Update()
        {
            //if (GameManager.instance._gameStatus==false) { return; }
            CheckMobileButtonBools();
            ProcessThrust();
            ProcessRotation();
            QuitApp();

        }
         private void CheckMobileButtonBools()
        {
            if (Button__SpaceBoostBool) { SpaceBut(); }
            if (Button__LeftButbool) { ButLeft(); }
            if (Button__RightButbool) { ButRight(); }
        }

        public static void QuitApp()
        {
            if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); }
        }

        public void ProcessThrust()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SpaceBut();
                //Debug.Log("Method OK");
            }
            //else { AudioSource.Stop(); MainBoost.Stop(); }
        }

        public void SpaceBut()
        {
            rb.AddRelativeForce(Vector3.up * MainThrust * Time.deltaTime);  // !! movement !!


            //if (!AudioSource.isPlaying) { AudioSource.PlayOneShot(mainEngine); }
            //if (!MainBoost.isPlaying) { MainBoost.Play(); }

            //AudioBase.instance.PlayMainEngine();
            

            



        }

        public void ProcessRotation()
        {
            if (Input.GetKey(KeyCode.A))
            {
                ButLeft();

            }
            else if (Input.GetKey(KeyCode.D))
            {
                ButRight();

            }
        }

        public void ButRight()
        {
            ApplyRotation(-MainRotate);
            //if (!LeftBoost.isPlaying) { LeftBoost.Play(); }
        }

        public void ButLeft()
        {
            ApplyRotation(MainRotate);
            //if (!RightBooster.isPlaying) { RightBooster.Play(); }
        }

        public void ApplyRotation(float iritationthisframe)
        {
            rb.freezeRotation = true;
            transform.Rotate(Vector3.forward * iritationthisframe * Time.deltaTime);
            rb.freezeRotation = false;
        }
    }
}
