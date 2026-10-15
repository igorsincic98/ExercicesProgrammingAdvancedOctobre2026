using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Statiques
{
    public class Cube : MonoBehaviour
    {
        public static List<Cube> Cubes = new List<Cube>();

        private void Awake()
        {
            Cubes.Add(this);
        }

        private void OnDestroy()
        {
            Cubes.Remove(this);
        }
    }
}