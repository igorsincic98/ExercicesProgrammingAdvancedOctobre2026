using System;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Statiques
{

    public class Ex4 : MonoBehaviour
    {
       [Range(0,1)] public float DestroyChance;

       private void Update()
       {
           if (Random.value < DestroyChance && Cube.Cubes.Count > 0)
           {
               Debug.Log("Deleting cube.");
               Debug.Log(Cube.Cubes.Count);
               Destroy(Cube.Cubes[0].gameObject);
           }
       }
    }
}