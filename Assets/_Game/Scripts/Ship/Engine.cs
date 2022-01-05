using Assigment.PowerUps;
using Assigment.ScriptableObjectsInventory.Items.Scripts;
using UnityEditor.VersionControl;
using UnityEngine;
using Variables;
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

        [SerializeField] private FloatVariable LaserSpeed;
        
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
                Debug.Log("klicked on potion");
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
                HealthPotionObject Object = ScriptableObject.CreateInstance<HealthPotionObject>();
                Object.Drink(GetComponent<Hull>()); //TODO fix just as the other potion
                
                inventory.RemoveItem(ItemType.HealthPotion, 1);
            }
        }
        public void DrinkSpeedPotion()
        {
            if (inventory.Contains(ItemType.LaserSpeedPotion ,out ItemType item ))
            {
                LaserSpeedPotionObject Object = ScriptableObject.CreateInstance<LaserSpeedPotionObject>();
                Object.Drink(LaserSpeed);
                
                inventory.RemoveItem(ItemType.LaserSpeedPotion, 1);
            }
        }
    }
}
