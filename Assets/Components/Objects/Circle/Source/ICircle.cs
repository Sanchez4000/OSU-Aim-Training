using System;

namespace Components.Objects.HitCircle
{
    public interface ICircle
    {
        public CircleNumber Number { get; }
        public CircleSize Size { get; }

        public event Action<Circle> Clicked;
    }
}
