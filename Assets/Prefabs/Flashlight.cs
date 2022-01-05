using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] float intensityDecay = .1f;
    [SerializeField] float angleDecay = 1f;
    [SerializeField] float minumumAngle = 30f;

    Light flashlight;

    private void Start() 
    {
        flashlight = GetComponent<Light>();
    }

    private void Update() 
    {
        DecreaseLightIntensity();
        DecreaseLightAngle();
    }

    private void DecreaseLightIntensity()
    {
        flashlight.intensity -= intensityDecay * Time.deltaTime;
    }

    private void DecreaseLightAngle()
    {
        if(flashlight.spotAngle > minumumAngle)
        {
            flashlight.spotAngle -= angleDecay * Time.deltaTime;
        }
    }
}
