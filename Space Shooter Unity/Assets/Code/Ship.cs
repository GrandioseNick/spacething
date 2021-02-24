using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ship : MonoBehaviour
{
    //object
    public Rigidbody2D RigidBody2D;
    public Project projectprefab;
    public Transform projectilespawn;

    public GameObject thrustParticlePrefab;
    public Transform thrustPartibleSpawnPoint;
    //stats
    public float accel;
    public float maxSpeed;
    public float maxHealth;
    public float fireRate;
    public float projectilespeed;
    public AudioSource lasershoot;
    public AudioSource shiphit;

    [HideInInspector] public float currentspeed;
    [HideInInspector] public float currenthealth;

    private void Start()
    {
        currenthealth = maxHealth;
    }
    public void fireprojectile()
    {
        Project projectile = Instantiate(projectprefab, projectilespawn.position, projectilespawn.rotation);
        projectile.Rigidbody2D.AddForce(transform.up * projectilespeed);
        projectile.init90(gameObject);
        maxSpeed = 1;
        lasershoot.Play();
        Destroy(projectile, 5);
  
        maxSpeed = 1;

        maxSpeed = 5;
        }


    private void FixedUpdate()
    {
        if (maxSpeed < RigidBody2D.velocity.magnitude)
        {
            RigidBody2D.velocity = RigidBody2D.velocity.normalized * maxSpeed;
        }
    }
    public void thrust()
    {
        RigidBody2D.AddForce(transform.up * accel);
        currentspeed = maxSpeed;

        float randomX = Random.Range(-0.1f, 0.1f);
        float randomY = Random.Range(-0.1f, 0.1f);
        Vector3 spawnPosition = new Vector3(thrustPartibleSpawnPoint.position.x + randomX, thrustPartibleSpawnPoint.position.y + randomY, 0);
        Instantiate(thrustParticlePrefab, spawnPosition, transform.rotation);
    }
    public void explode()
    {
        Instantiate(Resources.Load("Explosion"),transform.position, transform.rotation);
        Destroy(gameObject);
    }
    public void damagehit()
    { }
    public void takedamage(int damage)
    {
        currenthealth -= damage;
        if (currenthealth <= 0)
            shiphit.Play();
        {
            explode();
        }

    }
}
