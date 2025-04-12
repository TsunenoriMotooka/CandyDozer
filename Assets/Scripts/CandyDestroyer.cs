using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour
{
    public CandyManager candyManager;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Candy")
        {
            Destroy(other.gameObject);

            candyManager.AddCandy(1);
        }        
    }
}
