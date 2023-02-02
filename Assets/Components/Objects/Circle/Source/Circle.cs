using System;
using UnityEngine;

namespace Components.Objects.HitCircle
{
    public class Circle : MonoBehaviour, ICircle
    {
        [SerializeField] private CircleNumber _number;

        private CircleSize _size;

        public event Action<Circle> Clicked;

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
