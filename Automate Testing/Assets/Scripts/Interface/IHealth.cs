
    public interface IHealth
    {
        float CurrentHealth { get; set; }
        void Heal(float healAmount);
        void Damage(float damageAmount);
    }
