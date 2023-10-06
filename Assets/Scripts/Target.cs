using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int scoreValue = 1;
    //The score amount to award when shot when scoring is implemented
    public void HitTarget()
    {
        gameObject.SetActive(false);
        Console.Write("You Hit A Target!!");
    }
}
