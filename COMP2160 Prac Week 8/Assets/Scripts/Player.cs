using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float vx;
    private float vy;
    Vector3 Direction;
    Vector3 velocity;
    [SerializeField]
    private float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vx = Input.GetAxis("Horizontal");
        vy = Input.GetAxis("Vertical");

        Direction = new Vector3(vx, vy, 0);
        velocity = Direction * speed;
        transform.Translate(velocity * Time.deltaTime);

    }
}
