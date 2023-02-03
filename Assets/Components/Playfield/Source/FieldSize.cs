using System;
using UnityEngine;

namespace Assets.Components.Playfield.Source
{
    [Serializable]
    public class FieldSize
    {
        private const int DEFAULT_SCREEN_HEIGHT = 480;
        private const int DEFAULT_FIELD_HEIGHT = 376;
        private const float FIELD_RATIO = 4 / 3F;

        public int Width { get; private set; }
        public int Height { get; private set; }

        public FieldSize()
        {
            var scaleFactor = Screen.height / (DEFAULT_SCREEN_HEIGHT * 1F);
            Height = (int)(DEFAULT_FIELD_HEIGHT * scaleFactor);
            Width = (int)(Height * FIELD_RATIO);
        }
    }
}
