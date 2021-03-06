﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using eageramoeba.DetectResize;

namespace eageramoeba.DetectResize
{
    public class DetectResize : MonoBehaviour
    {
    
        public float updateFrequency = 2f;
    
        private float scW;
        private float scH;
    
        static public bool hasResized = false;
    
        // Use this for initialization
        void Start ()
        {
            StartCoroutine ("checkFrequent");
        }
        
        // Update is called once per frame
        void Update ()
        {
            
        }

        void checkResize ()
        {
            if (scW != Screen.width || scH != Screen.height) {
                DetectResize.hasResized = true;
                scW = Screen.width;
                scH = Screen.height;
            } else {
                DetectResize.hasResized = false;
            }
        }

        IEnumerator checkFrequent ()
        {
            checkResize ();
            yield return new WaitForSeconds (updateFrequency);
            StartCoroutine ("checkFrequent");
        }
    }
}