using System;
using UnityEngine;

namespace ClassesEtReferences
{
    public class Ex4 : MonoBehaviour
    {
        private GameObject _createdCube;

        private void DestroyCube()
        {
            Destroy(_createdCube);
        }

        private void CreateSpinningCube()
        {
            _createdCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _createdCube.AddComponent<Rigidbody>();
            _createdCube.AddComponent<SpinningComponent>();
            _createdCube.GetComponent<SpinningComponent>().IsSpinning = true;
            Invoke("DestroyCube", 1);
        }

        private void Start()
        {
            InvokeRepeating("CreateSpinningCube", 0, 2);
        }
    }
}