using UnityEngine;

namespace Character.Components.Live
{
    public class ImmortalLiveComponent : ILiveComponent
    {
        public float MaxHealth { get => 1; set { } }
        public float Health { get => 1; set { } }

        public void SetDamage(float damage)
        {
            Debug.Log("I am immortal!");
        }
    }
}
