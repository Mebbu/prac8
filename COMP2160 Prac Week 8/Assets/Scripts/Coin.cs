using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collide with: " + other.gameObject.name);
        Scorekeeper.Instance.AddPoints();
        Destroy(gameObject);
    }
}
