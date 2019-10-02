using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// This is a test script to tell if your weapons are actually shooting/hitting a target. 
    /// Play this script on a gameobject and make sure to give it a tag of Enemy
    /// </summary>


   public void TakeDamage(float _amnt)
    {
        Debug.Log("Enemy was hit with " + _amnt.ToString() + " of damage");
    }
}
