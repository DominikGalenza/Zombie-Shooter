using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] int ammoAmount = 15;

    public int GetCurrentAmmo()
    {
        return ammoAmount;
    }
    public void IncreaseAmmo()
    {
        ammoAmount++;
    }

    public void DecreaseAmmo()
    {
        ammoAmount--;
    }
}
