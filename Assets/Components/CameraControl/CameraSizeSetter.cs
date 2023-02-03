using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Components.CameraControl
{
    [RequireComponent(typeof(Camera))] public class CameraSizeSetter : MonoBehaviour
    {
        void Start()
        {
            var camera = GetComponent<Camera>();
            camera.orthographicSize = Screen.height / 2;
        }
    }
}