using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Crossbow : Archer
{
    public override void Attack()
    {
        base.Attack();
        Debug.Log("Crossbow");
    }
}
