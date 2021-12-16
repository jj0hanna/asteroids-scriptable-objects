using System.Collections;
using Assigment.PowerUps;
using UnityEngine;

namespace Assigment.powerUpSpawner
{
    public class PowerUpSpawner : MonoBehaviour
    {
        [SerializeField] private PowerUpObjects[] powerUps;
        
        
        private Camera _camera;
        private float spawnIntervall = 5f; // använda floatevent?
        private Vector3 spawnPosition;
        
        void Start()
        {
        _camera = Camera.main;
        }

        
        void Update()
        {
        
        }

        public IEnumerator SpawnPowerUps()
        {
            //TODO fix spawnpotition, so its inside the cameraview in GetSpawnPotition
            while (true)
            {
                spawnPosition = GetSpawnPotitions();
                PowerUpObjects powerUp = powerUps[Random.Range(0, powerUps.Length)];
                Instantiate(powerUp, new Vector3(Mathf.Round(spawnPosition.x), Mathf.Round(spawnPosition.y)),Quaternion.identity);
                yield return new WaitForSeconds(spawnIntervall);
            }
           
        }

        private Vector2 GetSpawnPotitions()
        {
            return new Vector2(); // eller _camera.ScreenToWorldPoint();
        }
    }
}
