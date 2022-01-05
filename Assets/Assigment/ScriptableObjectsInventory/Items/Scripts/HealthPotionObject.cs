using Ship;
using UnityEngine;
using Variables;

namespace Assigment.ScriptableObjectsInventory.Items.Scripts
{
    public class HealthPotionObject : PotionObject
    {
        //[SerializeField] private IntObservable _healthObservable;
        private int addHealth = 2;
        
        public void Drink(Hull hull)
        {
            Debug.Log(hull); // TODO this is not null but the other one is?
            hull.addHP(addHealth);
        }
    }
}
