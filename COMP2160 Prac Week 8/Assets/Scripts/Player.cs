using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float vx;
    private float vz;
    Vector3 Direction;
    Vector3 velocity;
    [SerializeField]
    private float speed;

    private string thisPlayer;

    private string Vertical;
    private string Horizontal;

    void Start()
    {
        if (CompareTag("Player"))
        {
            //thisPlayer = "p1"
            Vertical = InputAxes.Vertical;
            Horizontal = InputAxes.Horizontal;
        }
        else if (CompareTag("Player2"))
        {
            //thisPlayer = "p2"
            Vertical = InputAxes.Vertical_2;
            Horizontal = InputAxes.Horizontal_2;
        }
    }

    void Update()

    {
        //if(p1)
        Move(Horizontal, Vertical);

        //If Player 2
        //Move(Vertical_2, Horizontal_2);
    }

    void Move(string moveX, string moveY)
    {
        vx = Input.GetAxis(moveX);
        vz = Input.GetAxis(moveY);

        Direction = new Vector3(vx, 0, vz);
        velocity = Direction * speed;
        transform.Translate(velocity * Time.deltaTime);

    }

    
}

class InputAxes
{
    public const string Vertical = "Vertical";
    public const string Horizontal = "Horizontal";
    public const string Vertical_2 = "Vertical_2";
    public const string Horizontal_2 = "Horizontal_2";
}