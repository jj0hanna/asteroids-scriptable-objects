using Assigment.PowerUps;
using UnityEditor.VersionControl;
using UnityEngine;
using Variables;
using HealthPotion = Assigment.ScriptableObjectsInventory.Items.Scripts.HealthPotion;
using LaserSpeedPotion = Assigment.ScriptableObjectsInventory.Items.Scripts.LaserSpeedPotion;
using LaserSpeedPotions = Assigment.PowerUps.LaserSpeedPotion;



namespace Ship
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Engine : MonoBehaviour
    {
        [SerializeField] private FloatVariable _throttlePower;
        [SerializeField] private FloatVariable _rotationPower;
        
        [SerializeField] private float _throttlePowerSimple;
        [SerializeField] private float _rotationPowerSimple;

        //[SerializeField] private IntObservable _healthObservable;
        
        private Rigidbody2D _rigidbody;
        
        public InventoryObject inventory;
        
        private void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Throttle();
            }
        
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                SteerLeft();
            } 
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                SteerRight();
            }
//TODO fix so when i press it does not take more then one pot
            if (Input.GetKey(KeyCode.Alpha1))
            {
                DrinkHealthPotion();
            }

            if (Input.GetKey(KeyCode.Alpha2))
            {
                DrinkSpeedPotion();
            }
        }

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
    
        public void Throttle()
        {
            _rigidbody.AddForce(transform.up * _throttlePower.Value, ForceMode2D.Force);
        }

        public void SteerLeft()
        {
            _rigidbody.AddTorque(_rotationPower.Value, ForceMode2D.Force);
        }

        public void SteerRight()
        {
            _rigidbody.AddTorque(-_rotationPower.Value, ForceMode2D.Force);
        }
        public void DrinkHealthPotion()
        {
            if (inventory.Contains(ItemType.HealthPotion ,out ItemType item ))
            {
                HealthPotion Object = ScriptableObject.CreateInstance<HealthPotion>();
                Object.Drink(GetComponent<Hull>());
                
                Debug.Log("Drinking healthPotion");
                inventory.RemoveItem(ItemType.HealthPotion, 1);
            }
        }
        public void DrinkSpeedPotion()
        {
            if (inventory.Contains(ItemType.LaserSpeedPotion ,out ItemType item ))
            {
                LaserSpeedPotion Object = ScriptableObject.CreateInstance<LaserSpeedPotion>();
                Object.Drink(GetComponent<Laser>());
                
                
                Debug.Log("Drinking SpeedPotion");
                inventory.RemoveItem(ItemType.LaserSpeedPotion, 1);
            }
        }
    }
}
