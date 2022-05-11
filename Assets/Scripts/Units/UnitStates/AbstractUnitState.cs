using Scripts.Utility;

namespace Scripts.Units.UnitStates
{
    public abstract class AbstractUnitState : IState
    {
        public Unit Unit { get; }

        protected AbstractUnitState(Unit unit)
        {
            Unit = unit;
        }
        
        public abstract void OnEnter();

        public abstract void OnUpdate();

        public abstract IState NextState();

        public abstract void OnExit();
    }
}