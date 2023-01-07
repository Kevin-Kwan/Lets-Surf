using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Diagnostics;
namespace Fragsurf.Movement

{
    public class DisplayVelocity : MonoBehaviour
    {
        private bool start=true;
        public SurfCharacter jumpy;
        public Stopwatch timer;
        public startLevel starting;
        public nextLevel level;
        Text speed;
        void Start()
        {
            timer = new Stopwatch();
            speed = GetComponent<Text>();
        }

        // Update is called once per frame
        private void Update()
        {//UnityEngine.Debug.Log(jumpy.accessController());
            speed.text = jumpy.GetTheVelocity().ToString()+" units/sec";
            
        }
    }
}