using System;
using Asteroids;
using DefaultNamespace.ScriptableEvents;
using RuntimeSets;
using UnityEngine;
using Variables;
//using LaserSpeedPotions = Assigment.PowerUps.LaserSpeedPotion;

namespace Ship
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Laser : MonoBehaviour
    {
        [Header("Project References:")] [SerializeField]
        private LaserRuntimeSet _lasers;

        [Header("Values:")] 
        [SerializeField] private FloatVariable speed;
        
        private float maxLazerSpeed = 1f;
        private Rigidbody2D _rigidbody;
        
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _lasers.Add(gameObject);
            Debug.Log(" Amount Of Lasers: " + _lasers.Amount);
        }

        private void OnDestroy()
        {
            _lasers.Remove(gameObject);
        }

        private void FixedUpdate()
        {
            var trans = transform;
            _rigidbody.MovePosition(trans.position + trans.up * speed.Value);
            Debug.Log(speed.Value);
        }
        public void AddLaserSpeed(float laserSpeed)
        {
            Debug.Log("add speed");
            if (speed.Value < maxLazerSpeed)
            {
                Debug.Log("inside if add speed");
                speed.ApplyChange(laserSpeed);
            }
            
        }
    }
}
