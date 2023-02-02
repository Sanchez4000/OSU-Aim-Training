using System;
using TMPro;
using UnityEngine;

namespace Components.Objects.HitCircle
{
    [Serializable]
    public class CircleNumberView
    {
        [SerializeField] private TMP_Text _textContainer;

        public string Text
        {
            get => _textContainer.text;
            set
            {
                bool onlyDigits = true;

                foreach (char symbol in value)
                {
                    if (!char.IsDigit(symbol))
                    {
                        onlyDigits = false;
                        break;
                    }
                }

                if (!onlyDigits)
                {
                    throw new ArgumentException(
                        "Значением номера HitCircle может быть только число"
                    );
                }

                _textContainer.text = value;
            }
        }
    }
}
