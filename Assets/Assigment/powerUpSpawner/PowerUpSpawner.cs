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
        [SerializeField] private float spawnIntervall = 0.5f; // använda floatevent?
        
        private Camera _camera;
        
        private Vector3 spawnPosition;
        private Vector2 screenHalfSizeWorldUnits;

        private void Awake()
        {
            _camera = Camera.main;
            screenHalfSizeWorldUnits = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
            //spawnRoutine = StartCoroutine("SpawnBomb");
            StartCoroutine(nameof(SpawnPowerUps));
        }

        void Start()
        {
            
        }

        
        void Update()
        {
        
        }

        public IEnumerator SpawnPowerUps()
        {
            //TODO fix spawnpotition, so its inside the cameraview in GetSpawnPotition
            while (true)
            {
                //spawnPosition = GetSpawnPotitions();
                
                Vector2 spawnPosition = new Vector2(Random.Range(-screenHalfSizeWorldUnits.x, screenHalfSizeWorldUnits.x), Random.Range(-screenHalfSizeWorldUnits.y, screenHalfSizeWorldUnits.y));

                PowerUpObjects powerUp = powerUps[Random.Range(0, powerUps.Length)];
                Instantiate(powerUp, new Vector3(Mathf.Round(spawnPosition.x), Mathf.Round(spawnPosition.y)),Quaternion.identity);
                yield return new WaitForSeconds(spawnIntervall);
            }
           
        }

        private Vector2 GetSpawnPotitions()
        {
            //Vector2 spawnPositions = new Vector2(Random.Range(-screenHalfSizeWorldUnits.x, screenHalfSizeWorldUnits.x), Random.Range(-screenHalfSizeWorldUnits.y, screenHalfSizeWorldUnits.y));
            //Instantiate(prefabBomb,  new Vector3(spawnPosition.x, 0, spawnPosition.y), Quaternion.identity);
            //yield return new WaitForSeconds(spawnInterval);
            return new Vector2(); // eller _camera.ScreenToWorldPoint();
        }
    }
}
