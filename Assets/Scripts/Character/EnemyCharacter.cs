using UnityEngine;
using Character.Components.Damage;
using Character.Components.Live;
using Character.Components.Movement;

namespace Character
{
    public class EnemyCharacter : Character
    {
        private StateMachine stateMachine;
        public AIStateChase chaseState = new AIStateChase();
        public AIStateAttack attackState = new AIStateAttack();
        public float AttackRange = 3f;
        public Character TargetCharacter { get; private set; }
        public float TimeBetweenAttackCounter { get; set; }

        public override void Start()
        {
            base.Start();

            LiveComponent = new ImmortalLiveComponent();
            DamageComponent = new CharacterDamageComponent();
            TargetCharacter = FindObjectOfType<PlayerCharacter>();

            if (TargetCharacter == null)
            {
                Debug.LogError("PlayerCharacter not found. Ensure there is a PlayerCharacter in the scene.");
                return;
            }

            stateMachine = new StateMachine();
            stateMachine.Initialize(chaseState); // ”станавливаем начальное состо€ние преследовани€
        }

        public override void Update()
        {
            stateMachine.Update(this);
        }

        public void ChangeState(AIState newState)
        {
            stateMachine.ChangeState(newState, this);
        }
    }
}
