using UnityEngine;
using Variables;
using DefaultNamespace.ScriptableEvents;
using LaserSpeedPotions = Assigment.PowerUps.LaserSpeedPotion;

namespace Assigment.PowerUps
{
    public class LaserSpeedPotion : MonoBehaviour
    {
        [SerializeField] private FloatVariable LaserSpeed;
        [SerializeField] private float addChange = 0.1f;
        private float maxLazerSpeed = 1f;
    
        private void OnCollisionEnter2D(Collision2D other)
        {
             
          // if (string.Equals(other.gameObject.tag, "Player"))
          // {
          //     AddSpeedToLazer();
          // }

          // else
            {
                Destroy(gameObject);
            }
        }
         public void AddLaserSpeed1(float laserSpeed)
         {
             
             if (LaserSpeed.Value < maxLazerSpeed)
             {
                 LaserSpeed.ApplyChange(laserSpeed);
             }
             
         }

       // private void AddSpeedToLazer()
       // {
       //     if (LaserSpeed.Value < maxLazerSpeed)
       //     {
       //         LaserSpeed.ApplyChange(addChange);
       //     }
       // }
    
    }
}
