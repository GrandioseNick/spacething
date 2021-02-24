using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Ship
{

    private void Update()
    {
        Followmouse();
        handleuserinput();
    }
    void handleuserinput()
    {
        if (Input.GetMouseButton(1))
        {
            thrust();
        }
        if(Input.GetMouseButtonDown(0))
        {
            fireprojectile();
        }
    }
    public void Followmouse()
    {
        Vector3 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 positiontoface = new Vector2(mouseposition.x - transform.position.x, mouseposition.y - transform.position.y);
        transform.up = positiontoface;
    }

}
