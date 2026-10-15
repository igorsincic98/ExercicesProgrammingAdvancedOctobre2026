using System;
using UnityEngine;
using Object = System.Object;

namespace ClassesEtReferences
{
    public class Ex5 : MonoBehaviour
    {
        public MeshRenderer SphereMeshRenderer;
        public GameObject CylinderGameObject;
        public SpinningComponent CubeSpinningComponent;
        public Color ColorToApply;
        public bool _isCylinderActive;

        private void SwitchCylinder()
        {
            CylinderGameObject.SetActive(_isCylinderActive);
            _isCylinderActive = !_isCylinderActive;
        }

        private void Start()
        {
            SphereMeshRenderer.material.color = ColorToApply;
            InvokeRepeating("SwitchCylinder", 0, 1);
            CubeSpinningComponent.IsSpinning = true;
        }
    }
}