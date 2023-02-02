using Components.Objects.HitCircle;
using UnityEngine;

namespace Components.Containers.Playfield.Tests
{
    public class ICircleToCircleTest : MonoBehaviour
    {
        [SerializeField] private Playfield _playfield;

        public void Test()
        {
            float x = Random.Range(0F, 1F);
            float y = Random.Range(0F, 1F);

            var circle = _playfield.SetCircle(x, y);
            ICircle iCircle = circle;
            Circle normalCircle = (Circle)iCircle;

            Debug.Log(circle);
            Debug.Log(iCircle);
            Debug.Log(normalCircle);
        }
    }
}
