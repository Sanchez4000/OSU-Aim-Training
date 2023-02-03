using System;
using UnityEngine;

namespace Assets.Components.Playfield.Source
{
    [Serializable]
    public class FieldSize
    {
        private const float FIELD_ASPECT_RATIO = 4F / 3F;
        private const float SCALE_FACTOR = 376F / 480F;

        public int Width { get; private set; }
        public int Height { get; private set; }

        public FieldSize()
        {
            Height = (int)Math.Round(Screen.height * SCALE_FACTOR);
            Width = (int)(Height * FIELD_ASPECT_RATIO);
        }
    }
}
