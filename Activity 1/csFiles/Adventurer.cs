using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurer : MonoBehaviour
{
    public string adventName;
    public int attack;
    
    public virtual void Attack()
    {
        Debug.Log("Adventurer");
    }
}
