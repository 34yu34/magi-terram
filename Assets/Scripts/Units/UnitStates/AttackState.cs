using Scripts.Stats;
using Scripts.Utility;
using UnityEngine;

namespace Scripts.Units.UnitStates
{
    public class AttackState : AbstractUnitState
    {
        private Timer _next_attack_time;

        private Stat AttackSpeed => Unit.GetStat(StatsTypes.AttackSpeed);

        public AttackState(Unit unit) : base(unit)
        { }

        public override void OnEnter()
        {
            _next_attack_time = Timer.In(1f / AttackSpeed.CurrentValue);
        }

        public override void OnUpdate()
        {
            throw new System.NotImplementedException();
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