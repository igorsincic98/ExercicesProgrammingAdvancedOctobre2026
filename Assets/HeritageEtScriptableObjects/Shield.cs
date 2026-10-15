using UnityEngine;

[CreateAssetMenu(fileName = " Shied ")]
public class Shield : OneHandedItem
{
    public int Protection;

    public override void Use()
    {
        Debug.Log(TextSound + " : You raise " + name + " protecting from " + Protection + " damages.");
    }
}
