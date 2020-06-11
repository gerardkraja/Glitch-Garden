using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerCollider : MonoBehaviour
{
    HealthDisplay healthDisplay;
    void Start()
    {
        healthDisplay = FindObjectOfType<HealthDisplay>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        healthDisplay.DealDamage();
    }
}
