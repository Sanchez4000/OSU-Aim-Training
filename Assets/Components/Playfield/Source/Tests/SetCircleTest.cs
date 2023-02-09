using UnityEngine;

namespace Assets.Components.Playfield.Source.Tests
{
    public class SetCircleTest : MonoBehaviour
    {
        [SerializeField] private GamePlayfield _inspected;

        public void Test()
        {
            float x = Random.Range(0F, 1F);
            float y = Random.Range(0F, 1F);

            _inspected.SetCircle(x, y);
        }
    }
}
