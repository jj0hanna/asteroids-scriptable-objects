using UnityEngine;

namespace Assigment.ScriptableObjectsInventory.Items.Scripts
{
   [CreateAssetMenu(fileName = "new Default Potion", menuName = "Inventory System/Items/Potion")]
   public class PotionObject : ItemObject
   {
      private void Awake()
      {
         type = ItemType.HealthPotion;
         type = ItemType.LaserSpeedPotion;
      }
   }
}
