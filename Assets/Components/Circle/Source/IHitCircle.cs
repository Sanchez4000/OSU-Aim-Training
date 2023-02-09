using System;
using Assets.Components.Circle.Source.Modules;

namespace Assets.Components.Circle.Source
{
    public interface IHitCircle
    {
        public CircleNumber Number { get; }
        public CircleSize Size { get; }

        public event Action<IHitCircle> Clicked;
    }
}
