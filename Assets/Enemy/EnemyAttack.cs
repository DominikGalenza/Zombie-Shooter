using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 25f;
    
    void Update()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    public void HitEvent()
    {
        if(target == null) return;
        target.TakeDamage(damage);
        Debug.Log("Hit");
    }
}
