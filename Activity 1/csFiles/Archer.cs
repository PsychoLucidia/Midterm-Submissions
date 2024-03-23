using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Archer : Adventurer
{
    public override void Attack()
    {
        base.Attack();
        Debug.Log("Archer");
    }
}
