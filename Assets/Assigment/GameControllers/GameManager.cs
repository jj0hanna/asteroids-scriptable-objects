using UnityEngine;
using Variables;

namespace Assigment.GameControllers
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private GameObject gameOverPanel;
        [SerializeField] private InventoryObject inventory;
        [SerializeField] private IntObservable _healthObservable;
        [SerializeField] private IntVariable _health;
        [SerializeField] private FloatVariable LaserSpeed;
        //[SerializeField] private IntObservable StartHealth;
        private float StartLaserSpeed;
        void Start()
        {
            LaserSpeed.ResetValueToStandard();
            _healthObservable.SetValue(_health.Value);
            gameOverPanel.SetActive(false);
            inventory.Container.Clear();
            Time.timeScale = 1;
        }

        public void GameOver()
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
