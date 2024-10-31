using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterInput
{
    Vector3 GetMovementInput();
    bool GetAttackInput();
}
