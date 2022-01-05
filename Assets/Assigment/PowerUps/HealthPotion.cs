using System;
using UnityEngine;
using Variables;

namespace Assigment.PowerUps
{
    public class HealthPotion : MonoBehaviour
    {
        private int DestroyAfterSeacond;
        

        private void Awake()
        {
            
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
             
            if (string.Equals(other.gameObject.tag, "Player"))
            {
                Destroy(gameObject);
            }
        }
        
       
    }
}
