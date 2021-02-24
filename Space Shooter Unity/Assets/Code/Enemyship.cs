using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemyship : Ship
{
    Transform target;
    public bool canshoot;
    public bool canflytotarget;

    void Awake()
    {
        target = FindObjectOfType<Mothership>().transform;
    }
    void Update()
    {
        if (canshoot)
        {

            Shoottarget();
        }
        if (canflytotarget)
        {
            flytowardstarget();
        }
        void Shoottarget()
        {

        }
        void flytowardstarget()
        {
            Vector2 directiontoface = new Vector2(target.position.x - transform.position.x, target.position.y - transform.position.y);
            transform.up = directiontoface;
            thrust();
        }
    }
}
