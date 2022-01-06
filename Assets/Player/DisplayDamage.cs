using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas receivedDamageCanvas;
    [SerializeField] float splatterTime = 0.5f;
    void Start()
    {
        receivedDamageCanvas.enabled = false;
    }

    public void ShowReceivedDamageCanvas()
    {
        StartCoroutine(ShowSplatter());
    }

    IEnumerator ShowSplatter()
    {
        receivedDamageCanvas.enabled = true;
        yield return new WaitForSeconds(splatterTime);
        receivedDamageCanvas.enabled = false;
    }
}
