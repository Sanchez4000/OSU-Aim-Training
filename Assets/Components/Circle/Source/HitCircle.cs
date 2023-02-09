using System;
using Assets.Components.Circle.Source.Modules;
using UnityEngine;

namespace Assets.Components.Circle.Source
{
    public class HitCircle : MonoBehaviour, ICircle
    {
        [SerializeField] private CircleNumber _number;

        private CircleSize _size;

        public event Action<HitCircle> Clicked;

        public CircleNumber Number => _number;
        public CircleSize Size => _size;

        private void Start()
        {
            _size = new CircleSize(transform);
            _size.Set(0);
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
