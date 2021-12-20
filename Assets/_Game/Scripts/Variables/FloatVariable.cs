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

       //public virtual void SetValue(float newValue)
       //{
       //    _currentValue = newValue;
       //}

        private void OnEnable()
        {
            _currentValue = _value;
        }
        
        

        //public float Value
        //{
        //    get => _value;
        //    set => _value = value;
        //}
        //public virtual void ApplyChange(float change)
        //{
        //    _currentValue += change;
        //}
    }
}
