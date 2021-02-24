using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Project : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public int damagetogive;
    public GameObject owner;
    
    private void ontiggerenter2d(Collider2D collision)
    {
           if(collision.GetComponent<Ship>()&& collision.gameObject != owner)
        {
            collision.GetComponent<Ship>().takedamage(damagetogive);
            Destroy(gameObject);
        }
    }
    public void init90(GameObject firingship)
    {
        owner = firingship;
    }
}
