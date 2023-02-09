using Assets.Components.Circle.Source;
using Assets.Components.GameControl.Source.Modules;
using Assets.Components.Playfield.Source;
using UnityEngine;

namespace Assets.Components.GameControl.Source
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private PlayfieldCreator _creator;
        [SerializeField] private int _maxCircleCount = 3;
        [SerializeField][Range(2F, 7F)] private float _circleSize = 2F;

        private IGamePlayfield _playfield = null;

        private void Start()
        {
            if (_playfield == null)
            {
                _playfield = _creator.Create();
            }

            _playfield.CircleSize = _circleSize;

            TestCreateCircles();
        }

        private void TestCreateCircles()
        {
            int circleNumber = 1;

            for (int i = 0; i < _maxCircleCount; i++)
            {
                float x = Random.Range(0F, 1F);
                float y = Random.Range(0F, 1F);

                SetCircle(x, y, circleNumber);
                circleNumber++;
            }
        }

        private void SetCircle(float x, float y, int number = -1)
        {
            IHitCircle circle = _playfield.SetCircle(x, y);
            circle.Clicked += OnClircleClick;

            if (number == -1)
            {
                circle.Number.IsVisible = false;
            }
            else
            {
                circle.Number.Value = number;
                circle.Number.IsVisible = true;
            }
        }
        private void RemoveCircle(IHitCircle circle)
        {
            circle.Clicked -= OnClircleClick;
            _playfield.RemoveCircle(circle);
        }

        private void OnClircleClick(IHitCircle circle)
        {
            Debug.Log($"Circle [{circle.Number.Value}] clicked!");
        }
    }
}