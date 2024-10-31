using Character;
using UnityEngine;

public class StateMachine
{
    private AIState currentState;

    public void Initialize(AIState startingState)
    {
        currentState = startingState;
        currentState.EnterState(null); // Параметр null заменим на нужный объект, если требуется
    }

    public void ChangeState(AIState newState, EnemyCharacter enemy)
    {
        currentState?.ExitState(enemy);
        currentState = newState;
        currentState.EnterState(enemy);
    }

    public void Update(EnemyCharacter enemy)
    {
        currentState?.UpdateState(enemy);
    }
}
