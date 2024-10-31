using UnityEngine;
using Character.Components.Live;
using Character.Components.Movement;

namespace Character
{
    public class PlayerCharacter : Character
    {
        private ICharacterInput characterInput = new PlayerInput();

        public override void Start()
        {
            base.Start();
            LiveComponent = new CharacterLiveComponent();
        }

        public override void Update()
        {
            Vector3 movementVector = characterInput.GetMovementInput().normalized;

            MovableComponent.Move(movementVector);
            MovableComponent.Rotation(movementVector);
        }
    }
}
