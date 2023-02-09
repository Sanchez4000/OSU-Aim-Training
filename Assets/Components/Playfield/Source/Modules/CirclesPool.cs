using System;
using System.Collections.Generic;
using Assets.Components.Circle.Source;
using Code.Extensions;
using UnityEngine;

namespace Assets.Components.Playfield.Source.Modules
{
    [Serializable]
    public class CirclesPool
    {
        [SerializeField] private HitCircle _prefab;

        private List<HitCircle> _pool = new List<HitCircle>();

        public IEnumerable<HitCircle> Pool => _pool;

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
        public HitCircle Pull()
        {
            HitCircle HitCircle = _pool.Count > 0 ? _pool.Last() : UnityEngine.Object.Instantiate(_prefab);

            if (_pool.Contains(HitCircle))
            {
                _pool.Remove(HitCircle);
            }

            return HitCircle;
        }
        public void Push(HitCircle HitCircle)
        {
            _pool.Add(HitCircle);
        }

        private void GenerateBasePool(uint count)
        {
            for (int i = 0; i < count; i++)
            {
                var instance = UnityEngine.Object.Instantiate(_prefab);
                instance.gameObject.SetActive(false);

                _pool.Add(instance);
            }
        }
    }
}
