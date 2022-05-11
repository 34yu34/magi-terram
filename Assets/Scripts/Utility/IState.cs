namespace Scripts.Utility
{
    public interface IState
    {
        public void OnEnter();

        public void OnUpdate();

        public IState NextState();
        
        public void OnExit();
    }
}