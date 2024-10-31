using UnityEngine;
using Character;

public class AIStateAttack : AIState
{
    public override void EnterState(EnemyCharacter enemy)
    {
        // Логика при входе в состояние атаки (может быть пустой)
    }

    public override void UpdateState(EnemyCharacter enemy)
    {
        if (Vector3.Distance(enemy.TargetCharacter.transform.position, enemy.transform.position) > enemy.AttackRange)
        {
            enemy.ChangeState(enemy.chaseState);
        }
        else if (enemy.TimeBetweenAttackCounter <= 0)
        {
            enemy.DamageComponent.MakeDamage(enemy.TargetCharacter);
            enemy.TimeBetweenAttackCounter = enemy.characterData.TimeBetweenAttacks;
        }

        if (enemy.TimeBetweenAttackCounter > 0)
            enemy.TimeBetweenAttackCounter -= Time.deltaTime;
    }

    public override void ExitState(EnemyCharacter enemy)
    {
        // Логика при выходе из состояния атаки (может быть пустой)
    }
}
