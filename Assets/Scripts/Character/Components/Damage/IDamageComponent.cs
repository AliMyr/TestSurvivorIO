namespace Character.Components.Damage
{
    public interface IDamageComponent
    {
        float Damage { get; }

        void MakeDamage(Character characterTarget);
    }
}
