using System;
using Scripts.Stats;
using UnityEngine;

namespace Scripts.Units
{
    [RequireComponent(typeof(UnitStateMachine))]
    public class Unit : MonoBehaviour
    {
        [SerializeField] private StatsHandler _stats;

        private EffectsHandler _effects;

        private void Start()
        {
            Debug.Log(_stats[StatsTypes.Health]); 
        }

        public Stat GetStat(StatsTypes type)
        {
            return _stats[type];
        }
    }
}