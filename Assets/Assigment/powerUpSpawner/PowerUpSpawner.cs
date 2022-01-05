using System;
using System.Collections;
using Assigment.PowerUps;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assigment.powerUpSpawner
{
    public class PowerUpSpawner : MonoBehaviour
    {
        [SerializeField] private PowerUpObjects[] powerUps;
        [SerializeField] private float spawnIntervall = 0.5f;
        
        private Camera _camera;
        
        private Vector3 spawnPosition;
        private Vector2 screenHalfSizeWorldUnits;

        private void Awake()
        {
            _camera = Camera.main;
            screenHalfSizeWorldUnits = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
            StartCoroutine(nameof(SpawnPowerUps));
        }
        public IEnumerator SpawnPowerUps()
        {
            while (true)
            {
                yield return new WaitForSeconds(spawnIntervall);
                Vector2 spawnPosition = new Vector2(Random.Range(-screenHalfSizeWorldUnits.x, screenHalfSizeWorldUnits.x), Random.Range(-screenHalfSizeWorldUnits.y, screenHalfSizeWorldUnits.y));

                PowerUpObjects powerUp = powerUps[Random.Range(0, powerUps.Length)];
                Instantiate(powerUp, new Vector3(Mathf.Round(spawnPosition.x), Mathf.Round(spawnPosition.y)),Quaternion.identity);
                yield return new WaitForSeconds(spawnIntervall);
            }
        }
    }
}
