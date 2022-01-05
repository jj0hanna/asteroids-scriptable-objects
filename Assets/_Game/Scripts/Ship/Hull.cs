using Assigment.GameControllers;
using DefaultNamespace.ScriptableEvents;
using UnityEngine;
using Variables;

namespace Ship
{
    public class Hull : MonoBehaviour
    {
        //[SerializeField] private IntVariable _health;
        [SerializeField] private ScriptableEventIntReference _onHealthChangedEvent;
        [SerializeField] private IntReference _healthRef;
        [SerializeField] private IntObservable _healthObservable;

        [SerializeField] private GameManager gameManager;

        public InventoryObject inventory;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (string.Equals(other.gameObject.tag, "Asteroid"))
            {
                
                
                Debug.Log("Hull collided with Asteroid");
                // TODO can we bake this into one call?
                //_healthRef.ApplyChange(-1);
                //_onHealthChangedEvent.Raise(_healthRef);
                _healthObservable.ApplyChange(-1);
                if (_healthObservable.Value <= 0)
                {
                    GameOver();
                }
            }

            if (string.Equals(other.gameObject.tag,"HealthPowerUp"))
            {
                inventory.AddItem(ItemType.HealthPotion, 1);
                Debug.Log("hit healthPotion");
            }
            if (string.Equals(other.gameObject.tag,"SpeedPowerUp"))
            {
                inventory.AddItem(ItemType.LaserSpeedPotion, 1);
                Debug.Log("hit healthPotion");
            }
            
        }
        public void addHP(int hp)
        {
            _healthObservable.ApplyChange(hp);
        }
        private void GameOver()
        {
            gameManager.GameOver();
            Debug.Log("GameOver");
        }
        
        
    }
}
