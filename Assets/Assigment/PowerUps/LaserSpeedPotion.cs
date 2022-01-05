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
            {
                Destroy(gameObject);
            }
        }
    }
}
