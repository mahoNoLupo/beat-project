using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LichPlaylableCharacter : PlaylableCharacter
{
    //Defense

    //Lich cannot block, it absorves damage with a shield that replenishes over time
    private float _energyShield;

    private float _shieldCooldown;

    //Damage

    //Fireball cast
    [SerializeField]
    private GameObject fireball;

    private float _fireballRange;

    private float _fireballDmg;


}
