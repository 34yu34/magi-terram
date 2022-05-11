using System;
using Scripts.Units.UnitStates;
using Scripts.Utility;
using UnityEngine;

namespace Scripts.Units
{
    public class UnitStateMachine : AbstractStateMachine
    {
        private Unit _attached_unit;

        private IState _attack_state;
        

        public void Start()
        {
            _attached_unit = GetComponent<Unit>();
            
            Debug.Assert(_attached_unit != null);

            _attack_state = new AttackState(_attached_unit);

        }
    }
}