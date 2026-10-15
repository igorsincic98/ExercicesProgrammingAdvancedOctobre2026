using UnityEngine;

namespace HeritageEtScriptableObjects
{
    public class Ex3 : MonoBehaviour
    {
        private void Start()
        {
            Tower BlackTower = new Tower();
            BlackTower.Movement();
            Piece WhiteTower = new Tower();
            WhiteTower.Movement();
        }
    }
    
    
    public abstract class Piece
    {
        public abstract void Movement();
            
    }

    public class Tower : Piece
    {
        public override void Movement()
        {
            Debug.Log("Tower moves on lines");
        }
    }
}