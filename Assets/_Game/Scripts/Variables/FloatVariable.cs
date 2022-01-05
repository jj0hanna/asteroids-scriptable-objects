using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Variables
{
    [CreateAssetMenu(fileName = "new FloatVariable", menuName = "ScriptableObjects/Variables/FloatVariable")]
    public class FloatVariable : ScriptableObject
    {
        [Range(0f, 10f)]
        [SerializeField] private float _value;
        
        private float _currentValue;
        
        
        public float Value => _currentValue;

        public virtual void ApplyChange(float change)
        {
            _currentValue += change;
        }

        public virtual void ResetValueToStandard()
        {
            _currentValue = _value;
        }

        private void OnEnable()
        {
            _currentValue = _value;
        }
    }
}
