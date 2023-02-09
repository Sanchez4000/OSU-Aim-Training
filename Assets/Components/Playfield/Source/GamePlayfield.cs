using System;
using UnityEngine;
using Assets.Components.Circle.Source;
using Assets.Components.Playfield.Source.Modules;
using Assets.Components.Playfield.Source.Extensions;

namespace Assets.Components.Playfield.Source
{
    public class GamePlayfield : MonoBehaviour, IGamePlayfield
    {
        [SerializeField] private CirclesPool _pool;
        [SerializeField] private float _zStep = 1f;

        private FieldSize _size = new FieldSize();
        private int _zIndex = 0;
        private float _circleSize = 2F;

        public float CircleSize
        {
            get => _circleSize;
            set
            {
                if (value < 2F || value > 7F)
                {
                    throw new ArgumentOutOfRangeException(
                        "Значение CircleSize может быть в пределах от 2 до 7"
                    );
                }

                _circleSize = value;
            }
        }

        private FieldSize Size => _size;
        private float ZIndex
        {
            get
            {
                var result = _zIndex * _zStep;
                _zIndex++;
                return result;
            }
        }

        public IHitCircle SetCircle(float x, float y)
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

            EnableCircle(circle);
            circle.SetPosition(localX, localY, ZIndex);
            circle.Size.Set(CircleSize);

            return circle;
        }
        public void RemoveCircle(IHitCircle circle)
        {
            DisableCircle((HitCircle)circle);
        }

        private void Start()
        {
            _pool.Initialize();
        }
        private void EnableCircle(HitCircle circle)
        {
            circle.transform.parent = transform;
            circle.gameObject.SetActive(true);
        }
        private void DisableCircle(HitCircle circle)
        {
            _pool.Push(circle);
            circle.gameObject.SetActive(false);
        }
    }
}
