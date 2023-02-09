using Assets.Components.Circle.Source;
using UnityEngine;

namespace Assets.Components.Playfield.Source.Tests
{
    public class ICircleToCircleTest : MonoBehaviour
    {
        [SerializeField] private GamePlayfield _playfield;

        public void Test()
        {
            float x = Random.Range(0F, 1F);
            float y = Random.Range(0F, 1F);

            var circle = _playfield.SetCircle(x, y);
            IHitCircle iCircle = circle;
            HitCircle normalCircle = (HitCircle)iCircle;

            Debug.Log(circle);
            Debug.Log(iCircle);
            Debug.Log(normalCircle);
        }
    }
}
