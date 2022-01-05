using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreIntensity = 5f;
    [SerializeField] float restoreAngle = 5f;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            other.GetComponentInChildren<Flashlight>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<Flashlight>().RestoreLightIntensity(restoreIntensity);
            Destroy(gameObject);
        }
    }
}
