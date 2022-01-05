using UnityEngine;
using Variables;
using DefaultNamespace.ScriptableEvents;
using LaserSpeedPotions = Assigment.PowerUps.LaserSpeedPotion;

namespace Assigment.PowerUps
{
    public class LaserSpeedPotion : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D other)
        {
             
            if (string.Equals(other.gameObject.tag, "Player"))
            {
                Destroy(gameObject);
            }
        }
      // private void OnCollisionEnter2D(Collision2D other)
      // {
      //     {
      //         Destroy(gameObject);
      //     }
      // }
    }
}
