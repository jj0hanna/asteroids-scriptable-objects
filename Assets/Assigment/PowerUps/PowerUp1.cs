using UnityEngine;
using Variables;

namespace Assigment.PowerUps
{
    public class PowerUp1 : MonoBehaviour
    {
        [SerializeField] private IntObservable _healthObservable;
        
        private void OnCollisionEnter2D(Collision2D other)
        {
             
            if (string.Equals(other.gameObject.tag, "Player"))
            {
                AddHp();
            }
            else
            {
                Destroy(gameObject);
            }
        }
        private void AddHp()
        {
            _healthObservable.ApplyChange(+2);
        }
    }
}
