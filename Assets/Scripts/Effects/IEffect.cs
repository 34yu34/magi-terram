namespace Scripts.Effects
{
    public interface IEffect
    {
        public void OnAdd();
        
        public void OnUpdate();

        public bool ShouldBeRemoved();

        public void OnRemove();
    }
}