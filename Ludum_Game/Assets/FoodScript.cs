using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    public bool isCollided = false;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Meat") )
        {
            Debug.Log("ДОЛБАЕБ");
            isCollided = true;
        }
    }
}