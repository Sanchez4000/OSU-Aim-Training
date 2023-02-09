using System;
using Assets.Components.Playfield.Source;
using UnityEngine;

namespace Assets.Components.GameControl.Source.Modules
{
    [Serializable]
    public class PlayfieldCreator
    {
        [SerializeField] private GamePlayfield _prefab;

        public IGamePlayfield Create()
        {
            return GameObject.Instantiate<GamePlayfield>(_prefab);
        }
    }
}