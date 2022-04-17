using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    int horizontalMove = 0;
    int verticalMove = 0;
    bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
            MovingHorizontal(horizontalMove);
            MovingVertical(verticalMove);
        }
    }
    public void MovingHorizontal(int h)
    {
        Vector3 position = this.transform.position;
        position.x += moveSpeed * Time.deltaTime *h;
        this.transform.position = position;
    }
    public void MovingVertical(int v)
    {
        Vector3 position = this.transform.position;
        position.y += moveSpeed * Time.deltaTime * v;
        this.transform.position = position;
    }

    public void IsButtonDown(string direction)
    {
        isMoving = true;
        if (direction.Equals("Up"))
        {
            verticalMove = 1;
        }
        else if(direction.Equals("Down"))
        {
            verticalMove = -1;
        }
        else if(direction.Equals("Left"))
        {
            horizontalMove = -1;
        }
        else if(direction.Equals("Right"))
        {
            horizontalMove = 1;
        }
    }
    public void IsButtonUp()
    {
        isMoving = false;
        horizontalMove = 0;
        verticalMove = 0;
    }
}
