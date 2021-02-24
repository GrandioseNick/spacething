using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mothership : Ship
{
    private void Update()
    {
        Followmouse();

    }

    public void Followmouse()
    {
        Vector3 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 positiontomove = new Vector3(mouseposition.x, mouseposition.y, 0); 
        transform.position = positiontomove;
    }



}
