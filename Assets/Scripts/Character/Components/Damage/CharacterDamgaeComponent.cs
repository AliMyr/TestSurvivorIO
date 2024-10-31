using UnityEngine;

namespace Character.Components.Damage
{
    public class CharacterDamageComponent : IDamageComponent
    {
        public float Damage => 10;

        public void MakeDamage(Character characterTarget)
        {
            if (characterTarget.LiveComponent != null)
                characterTarget.LiveComponent.SetDamage(Damage);
        }
    }
}
