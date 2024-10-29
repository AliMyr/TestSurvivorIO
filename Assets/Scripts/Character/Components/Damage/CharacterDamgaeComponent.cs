using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDamgaeComponent : IDamageComponent
{
    public float Damage => 10;

    public void MakeDamage(Character characterTarget)
    {
        if (characterTarget.LiveComponent != null) 
            characterTarget.LiveComponent.SetDamage(Damage);
    }
}
