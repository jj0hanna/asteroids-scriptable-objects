using System;
using UnityEngine;

namespace Ship
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private Laser _laserPrefab;

        [SerializeField] private float timeSinceLastShot;
        

        private void Update()
        {
           // if (Input.GetButton("Jump"))
           // {
           //     Debug.Log("HOlding down");
           // }
            if (Input.GetKeyDown(KeyCode.Space))    
                
                Shoot();
        }
        
        private void Shoot()
        {
            var trans = transform;
            Instantiate(_laserPrefab, trans.position, trans.rotation);
        }
        
    }
}
