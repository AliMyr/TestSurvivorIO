using UnityEngine;
using Character;

public class AIStateChase : AIState
{
    public override void EnterState(EnemyCharacter enemy)
    {
        // Логика при входе в состояние преследования (может быть пустой)
    }

    public override void UpdateState(EnemyCharacter enemy)
    {
        if (enemy.MovableComponent == null || enemy.TargetCharacter == null)
        {
            Debug.LogError("MovableComponent or TargetCharacter is null.");
            return;
        }

        Vector3 direction = enemy.TargetCharacter.transform.position - enemy.transform.position;
        direction.Normalize();

        enemy.MovableComponent.Move(direction);
        enemy.MovableComponent.Rotation(direction);

        if (Vector3.Distance(enemy.TargetCharacter.transform.position, enemy.transform.position) <= enemy.AttackRange)
        {
            enemy.ChangeState(enemy.attackState);
        }
    }

    public override void ExitState(EnemyCharacter enemy)
    {
        // Логика при выходе из состояния преследования (может быть пустой)
    }
}
