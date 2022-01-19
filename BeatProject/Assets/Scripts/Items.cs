using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newItem", menuName = "BeatGame/Items")]
public class Items : ScriptableObject
{
    public string itemName;

    public string itemDescription;

    //Item rarity and the spawn percentage in a tile.
    public Dictionary<string, float> itemRarity = new Dictionary<string, float>();

    public void useItem(string name) { }

}
