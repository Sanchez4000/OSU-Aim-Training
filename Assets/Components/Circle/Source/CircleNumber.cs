using System;
using UnityEngine;

namespace Assets.Components.Circle.Source
{
    [Serializable]
    public class CircleNumber
    {
        [SerializeField] private CircleNumberView _view;

        private int _value = 0;
        private bool _isVisible = true;

        private event Action DataChanged;

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
                DataChanged?.Invoke();
            }
        }
        public bool IsVisible
        {
            get => _isVisible;
            set
            {
                _isVisible = value;
                DataChanged?.Invoke();
            }
        }

        private void OnEnable() => DataChanged += UpdateView;
        private void OnDisable() => DataChanged -= UpdateView;

        private void UpdateView() => _view.Text = _isVisible ? _value.ToString() : string.Empty;
    }
}