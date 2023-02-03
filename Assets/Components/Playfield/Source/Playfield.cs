using System;
using UnityEngine;
using Assets.Components.Circle.Source;
using Assets.Components.Playfield.Extensions;

namespace Assets.Components.Playfield.Source
{
    public class GamePlayfield : MonoBehaviour
    {
        [SerializeField] private CirclesPool _pool;
        [SerializeField] private float _zStep = 1f;

        private FieldSize _size = new FieldSize();
        private int _zIndex = 0;

        public FieldSize Size => _size;

        private float ZCoord
        {
            get
            {
                var result = _zIndex * _zStep;
                _zIndex++;
                return result;
            }
        }

        public ICircle SetCircle(float x, float y)
        {
            if (x < 0 || x > 1)
            {
                string xName = nameof(x);

                throw new ArgumentOutOfRangeException(
                    xName,
                    x,
                    $"Значение {xName} может быть в пределах от 0 до 1"
                );
            }

            if (y < 0 || y > 1)
            {
                string yName = nameof(y);

                throw new ArgumentOutOfRangeException(
                    yName,
                    y,
                    $"Значение {yName} может быть в пределах от 0 до 1"
                );
            }

            HitCircle circle = _pool.Pull();
            float localX = _size.Width * (x - 0.5f);
            float localY = _size.Height * (y - 0.5f);

            PutCircle(circle);
            circle.SetPosition(localX, localY, ZCoord);

            return circle;
        }
        public void RemoveCircle(HitCircle circle)
        {
            _pool.Push(circle);
            circle.gameObject.SetActive(false);
        }
        public void RemoveCircle(ICircle circle)
        {
            RemoveCircle((HitCircle)circle);
        }

        private void Start()
        {
            _pool.Initialize();
        }
        private void PutCircle(HitCircle circle)
        {
            circle.transform.parent = transform;
            circle.gameObject.SetActive(true);
        }
    }
}
