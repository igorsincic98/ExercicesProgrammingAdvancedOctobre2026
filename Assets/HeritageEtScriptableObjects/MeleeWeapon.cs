using UnityEngine;

[CreateAssetMenu (fileName = "MeleeWeapon")]
public class MeleeWeapon : OneHandedItem
{
    public int Damage;

    public override void Use()
    {
        Debug.Log(TextSound + " : You attack with " + name + " dealing " + Damage + " damages.");
    }
}
