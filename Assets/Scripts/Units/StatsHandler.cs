using System;
using System.Collections.Generic;
using Scripts.Stats;
using UnityEngine;

namespace Scripts.Units
{
    [Serializable]
    public class StatsHandler
    {
        [SerializeField] private List<Stat> _stats;

        public Stat this[StatsTypes type] => _stats[(int)type];

        public void AddModification(StatsTypes type, StatModifier modifier)
        {
            this[type].AddModifier(modifier);
        }
        
        public void RemoveModification(StatsTypes type, StatModifier modifier)
        {
            this[type].RemoveModifier(modifier);
        }
    }
}