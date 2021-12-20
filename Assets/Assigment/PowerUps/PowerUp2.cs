using System;
using System.Collections;
using System.Collections.Generic;
using Ship;
using UnityEngine;
using Variables;

public class PowerUp2 : MonoBehaviour
{
    [SerializeField] private FloatVariable LaserSpeed;
    [SerializeField] private float addChange = 0.1f;
    private float maxLazerSpeed = 1f;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
             
        if (string.Equals(other.gameObject.tag, "Player"))
        {
            AddSpeedToLazer();
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void AddSpeedToLazer()
    {
        if (LaserSpeed.Value < maxLazerSpeed)
        {
            LaserSpeed.ApplyChange(addChange);
        }
    }
    
}
