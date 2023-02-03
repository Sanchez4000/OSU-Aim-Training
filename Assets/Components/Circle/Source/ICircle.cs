using System;

namespace Assets.Components.Circle.Source
{
    public interface ICircle
    {
        public CircleNumber Number { get; }
        public CircleSize Size { get; }

        public event Action<HitCircle> Clicked;
    }
}
