using System;
using UnityEngine;
using DefaultNamespace.ScriptableEvents;
using Variables;

namespace Assigment.PowerUps
{
    public class PowerUpObjects : MonoBehaviour
    {
        [SerializeField] private ScriptableEventInt playerCollideWithPowerUp;
        
        private int _instanceId;

        private void Start()
        {
            _instanceId = GetInstanceID();
        }

         private void OnCollisionEnter2D(Collision2D other)
         {
             
             if (string.Equals(other.gameObject.tag, "Player"))
             {
                 Debug.Log("hit");
                 IHitThePlayer();
             }
         }

        private void IHitThePlayer()
        {
            playerCollideWithPowerUp.Raise(_instanceId);
            Destroy(gameObject);
        }
        
        public void OnHitByThePlayer(IntReference powerUpID)
        {
            if (_instanceId == powerUpID.GetValue())
            {
                Destroy(gameObject);
            }
        }
        
        public void OnHitByThePlayer(int powerUpID)
        {
            if (_instanceId == powerUpID)
            {
                Destroy(gameObject);
            }
        }
    }
    
}