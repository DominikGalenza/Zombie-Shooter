using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float damage = 25f;
    
    void Update()
    {
        
    }

    public void HitEvent()
    {
        if(target == null) return;
        Debug.Log("Hit");
    }
}
