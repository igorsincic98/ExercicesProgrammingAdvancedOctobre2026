using System;
using System.IO;
using UnityEngine;

namespace Statiques
{
    public class Ex1 : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log(PathHelper.AssetFolder);
            Debug.Log(PathHelper.SpritesFolder);
            Debug.Log(PathHelper.PrefabsFolder);
        }
    }

    public static class PathHelper
    {
        public static string AssetFolder = Application.dataPath;
        public static string SpritesFolder = AssetFolder + Path.AltDirectorySeparatorChar + "Sprites";
        public static string PrefabsFolder = AssetFolder + Path.AltDirectorySeparatorChar + "Prefabs";
    }
}