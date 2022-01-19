using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaylableCharacter : MonoBehaviour
{
    //Base class to create individual playlable characters

    //Health Points
    [SerializeField]
    private float maxHP;

    private float _hitPoints;

    //Speed is universal and affected by timing input and items
    private float _speed;

    //Attack
    [SerializeField]
    private float _attackDmg;

    [SerializeField]
    private int _attackRange;

    //Block reduces damage in certain percentages.

    [SerializeField]
    private float _blockValue;

    //Abilities and specials

    [SerializeField]
    private List<Abilities> _abilities;
    
    
}
