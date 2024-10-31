using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : ICharacterInput
{
    public Vector3 GetMovementInput()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        return new Vector3(moveHorizontal, 0, moveVertical);
    }

    public bool GetAttackInput()
    {
        return Input.GetButtonDown("Fire1");
    }
}
