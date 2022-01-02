using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera playerCamera;
    [SerializeField] RigidbodyFirstPersonController playerController;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedOutSensitivityX = 2f;
    [SerializeField] float zoomedOutSensitivityY = 2f;
    [SerializeField] float zoomedInSensitivityX = 1f;
    [SerializeField] float zoomedInSensitivityY = 1f;

    bool zoomedIn;

    void OnDisable()
    {
        ZoomedOut();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(1) && gameObject.GetComponent<WeaponZoom>())
        {
            if(zoomedIn == false)
            {
                ZoomedIn();

            }
            else
            {
                ZoomedOut();
            }
        }
    }

    private void ZoomedIn()
    {
        zoomedIn = true;
        playerCamera.fieldOfView = zoomedInFOV;
        playerController.mouseLook.XSensitivity = zoomedInSensitivityX;
        playerController.mouseLook.YSensitivity = zoomedInSensitivityY;
    }

    private void ZoomedOut()
    {
        zoomedIn = false;
        playerCamera.fieldOfView = zoomedOutFOV;
        playerController.mouseLook.XSensitivity = zoomedOutSensitivityX;
        playerController.mouseLook.YSensitivity = zoomedOutSensitivityY;
    }
}
