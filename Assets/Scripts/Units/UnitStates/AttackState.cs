using Scripts.Stats;
using Scripts.Utility;
using UnityEngine;

namespace Scripts.Units.UnitStates
{
    public class AttackState : AbstractUnitState
    {
        private Timer _next_attack_timer;

        private Stat AttackSpeed => Unit.GetStat(StatsTypes.AttackSpeed);

        private float AttackCooldown => 1f / AttackSpeed.CurrentValue;

        public AttackState(Unit unit) : base(unit)
        { }

        public override void OnEnter()
        {
            _next_attack_timer = Timer.In(AttackCooldown);
        }

        public override void OnUpdate()
        {
            if (_next_attack_timer.IsCompleted())
            {
                Attack();
            }
        }

        private void Attack()
        {
            
        }

        public override IState NextState()
        {
            throw new System.NotImplementedException();
        }

        public override void OnExit()
        {
            throw new System.NotImplementedException();
        }
    }
}