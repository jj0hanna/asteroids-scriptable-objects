using System;
using UnityEngine;
using Variables;

namespace Assigment.PowerUps
{
    public class HealthPotion : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (string.Equals(other.gameObject.tag, "Player"))
            {
                Destroy(gameObject);
            }
        }
    }
}
