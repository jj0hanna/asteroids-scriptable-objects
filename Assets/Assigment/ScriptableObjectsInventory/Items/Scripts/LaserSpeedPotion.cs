using Ship;
using Variables;
using UnityEngine;


namespace Assigment.ScriptableObjectsInventory.Items.Scripts
{
    public class LaserSpeedPotion : PotionObject
    { 
        private float addChange = 0.1f;
        //private float maxLazerSpeed = 1f;
        public void Drink(Laser laser)
        {
            Debug.Log(laser);
            laser.AddLaserSpeed(addChange);
            //_healthObservable.ApplyChange(healthChange);
        }
        
    }
}
