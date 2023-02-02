using UnityEngine;

namespace Components.Containers.Playfield.Tests
{
    public class SetCircleTest : MonoBehaviour
    {
        [SerializeField] private Playfield _inspected;

        public void Test()
        {
            float x = Random.Range(0F, 1F);
            float y = Random.Range(0F, 1F);

            _inspected.SetCircle(x, y);
        }
    }
}
