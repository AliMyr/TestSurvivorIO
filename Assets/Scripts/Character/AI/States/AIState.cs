using Character;

public abstract class AIState
{
    public abstract void EnterState(EnemyCharacter enemy);
    public abstract void UpdateState(EnemyCharacter enemy);
    public abstract void ExitState(EnemyCharacter enemy);
}
