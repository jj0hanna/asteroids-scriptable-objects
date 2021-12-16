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

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                IHitThePlayer();
            }
        }
        private void IHitThePlayer()
        {
            
            playerCollideWithPowerUp.Raise(_instanceId);
            Destroy(gameObject);
        }

        // TODO Can we move this to a single listener, something like an AsteroidDestroyer?
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