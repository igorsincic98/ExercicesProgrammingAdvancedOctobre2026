using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Statiques
{
    public class Ex3 : MonoBehaviour
    {
        public GameObject CubePrefab;
        [Range(0,1)] public float SpawnChance;

        private void Update()
        {
            if (Random.value < SpawnChance)
            {
                Instantiate(CubePrefab, transform.position, transform.rotation);
            }
        }
    }
}