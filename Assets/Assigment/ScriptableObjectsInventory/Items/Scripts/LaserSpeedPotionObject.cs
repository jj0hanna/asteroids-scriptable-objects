using Assigment.PowerUps;
using Ship;
using Variables;
using UnityEngine;


namespace Assigment.ScriptableObjectsInventory.Items.Scripts
{
    public class LaserSpeedPotionObject : PotionObject
    { 
        private float addChange = 0.1f;
        public void Drink(FloatVariable laserspeed)
        {
            laserspeed.ApplyChange(addChange);
        }
        
    }
}
