using UnityEngine;
using Character.Components.Damage;
using Character.Components.Live;
using Character.Components.Movement;

namespace Character
{
    public abstract class Character : MonoBehaviour
    {
        [SerializeField]
        public CharacterData characterData;

        public IMovable MovableComponent { get; set; }
        public ILiveComponent LiveComponent { get; set; }
        public IDamageComponent DamageComponent { get; set; }

        public virtual void Start()
        {
            MovableComponent = new CharacterMovementComponent();
            MovableComponent.Initialize(characterData);
        }

        public abstract void Update();
    }
}
