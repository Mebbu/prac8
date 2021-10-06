using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collide with: " + other.gameObject.name);
        //Scorekeeper.Instance.AddPoints();
        if (other.tag == "Player")
        {
            Scorekeeper.Instance.AddPointsPlayer1();
        }

        if (other.tag == "Player2")
        {
            Scorekeeper.Instance.AddPointsPlayer2();
        }
            Destroy(gameObject);
    }
}
