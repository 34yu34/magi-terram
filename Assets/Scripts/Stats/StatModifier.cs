namespace Scripts.Stats
{
    public class StatModifier
    {
        private float _value;

        private StatModifierType _modifier_type;

        public StatModifier(float value, StatModifierType modifier_type)
        {
            _value = value;
            _modifier_type = modifier_type;
        }

        public float CalculatedModification(float base_value, float current_value)
        {
            return _modifier_type switch
            {
                StatModifierType.Fixed => _value,
                StatModifierType.Relative => _value * base_value,
                _ => 0
            };
        }
    }
}