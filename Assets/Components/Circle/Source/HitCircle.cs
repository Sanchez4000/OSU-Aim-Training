using System;
using Assets.Components.Circle.Source.Modules;
using UnityEngine;

namespace Assets.Components.Circle.Source
{
    public class HitCircle : MonoBehaviour, IHitCircle
    {
        [SerializeField] private CircleNumber _number;

        private CircleSize _size;

        public event Action<IHitCircle> Clicked;

        public CircleNumber Number => _number;
        public CircleSize Size => _size;

        private void Awake()
        {
            _size = new CircleSize(transform);
        }
        private void OnMouseOver()
        {
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X))
            {
                Clicked?.Invoke(this);
            }
        }
    }
}
