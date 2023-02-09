using System;
using UnityEngine;

namespace Assets.Components.Circle.Source.Modules
{
    [Serializable]
    public class CircleNumber
    {
        [SerializeField] private CircleNumberView _view;

        private int _value = 0;
        private bool _isVisible = true;

        public int Value
        {
            get => _value;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "Значение номера HitCircle не может быть меньше 1"
                    );
                }

                _value = value;
                UpdateView();
            }
        }
        public bool IsVisible
        {
            get => _isVisible;
            set
            {
                _isVisible = value;
                UpdateView();
            }
        }

        private void UpdateView() => _view.Text = _isVisible ? _value.ToString() : string.Empty;
    }
}