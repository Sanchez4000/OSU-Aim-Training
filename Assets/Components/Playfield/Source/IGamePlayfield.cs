using Assets.Components.Circle.Source;
using Assets.Components.Playfield.Source.Modules;

namespace Assets.Components.Playfield.Source
{
    public interface IGamePlayfield
    {
        public float CircleSize { get; set; }

        public IHitCircle SetCircle(float x, float y);
        public void RemoveCircle(IHitCircle circle);
    }
}