using Assets.Components.Playfield.Source;
using UnityEngine;

namespace Assets.Components.Playfield.Tests
{
    public class PlayfieldSizeTest : MonoBehaviour
    {
        [SerializeField] private GamePlayfield _inspected;

        public void Test()
        {
            for (int x = 0; x <= 1; x++)
            {
                for (int y = 0; y <= 1; y++)
                {
                    _inspected.SetCircle(x, y);
                }
            }
        }
    }
}