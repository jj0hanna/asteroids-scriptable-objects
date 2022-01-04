using Ship;
using UnityEngine;
using Variables;
namespace Assigment.ScriptableObjectsInventory.Items.Scripts
{
    public class HealthPotion : PotionObject
    {
        //[SerializeField] private IntObservable _healthObservable;
        private int addHealth = 2;
        
        public void Drink(Hull hull)
        {
            Debug.Log(hull);
            hull.addHP(addHealth);
            //_healthObservable.ApplyChange(healthChange);
        }
    }
}
