using System;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts.Stats
{
    
    [Serializable]
    public class Stat
    {
        [SerializeField] private float _base_value;
        public float BaseValue => _base_value;

        [SerializeField] private float _current_value;

        public float CurrentValue
        {
            get
            {
                if (_is_dirty)
                {
                    CalculateValue();
                }

                return _current_value;
            }
        }

        private bool _is_dirty;

        private List<StatModifier> _modifiers;

        public Stat()
        {
            _base_value = 0;
            _current_value = 0;
            _is_dirty = true;
            _modifiers = new List<StatModifier>();
        }

        public void AddModifier(StatModifier modifier)
        {
            if (_modifiers.Contains(modifier))
            {
                return;
            }
            
            _is_dirty = true;
            
            _modifiers.Add(modifier);
        }

        public void RemoveModifier(StatModifier modifier)
        {
            if (_modifiers.Remove(modifier))
            {
                _is_dirty = true;
            }
        }

        private void CalculateValue()
        {
            _current_value = _base_value;

            foreach (var modifier in _modifiers)
            {
                _current_value += modifier.CalculatedModification(_base_value, _current_value);
            }
            
            _is_dirty = false;
        }
        
        public override string ToString()
        {
            return $"Current : {_current_value} | Base : {_base_value}";
        }
    }
}
