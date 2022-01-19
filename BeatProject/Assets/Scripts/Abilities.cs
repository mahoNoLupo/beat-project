using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newAbility", menuName = "BeatGame/Characters/Abilities")]
public class Abilities : ScriptableObject
{
    public string abilityName;

    public string abilityDescription;

    public float abilityCooldown;

    //Generic method to implement different functionality
    public void PerformAbility() { }

}
