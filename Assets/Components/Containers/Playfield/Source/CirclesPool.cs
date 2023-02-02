using System;
using System.Collections.Generic;
using Code.Extensions;
using Components.Objects.HitCircle;
using UnityEngine;

namespace Components.Containers.Playfield
{
    [Serializable]
    public class CirclesPool
    {
        [SerializeField] private Circle _prefab;

        private List<Circle> _pool = new List<Circle>();

        public IEnumerable<Circle> Pool => _pool;

        public void Initialize(uint elemenstCount = 10)
        {
            if (_prefab == null)
            {
                throw new MissingReferenceException(
                    "Требуется префаб для создания пула объектов"
                );
            }

            GenerateBasePool(elemenstCount);
        }
        public Circle Pull()
        {
            Circle circle = _pool.Count > 0 ? _pool.Last() : MonoBehaviour.Instantiate(_prefab);

            if (_pool.Contains(circle))
            {
                _pool.Remove(circle);
            }

            return circle;
        }
        public void Push(Circle circle)
        {
            _pool.Add(circle);
        }

        private void GenerateBasePool(uint count)
        {
            for (int i = 0; i < count; i++)
            {
                var instance = MonoBehaviour.Instantiate(_prefab);
                instance.gameObject.SetActive(false);

                _pool.Add(instance);
            }
        }
    }
}
