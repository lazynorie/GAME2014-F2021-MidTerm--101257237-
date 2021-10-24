/// BulletController.cs
/// Jing Yuan Cheng 101257237
/// Last modified: 22/10/2021
/// This script controlls movements of bullets
/// version history
/// Version 1.1 original file
/// Version 1.2 change the orientation of the bullet movements

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    //control the movement of the bullets, now its from left to right now 
    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }
    
    //check if bullets are out of bound, if they are then return them to the bullet pool
    private void _CheckBounds()
    {
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    //check if bullets are colliding with other game object. if they are, then return them to the pool
    public void OnTriggerEnter2D(Collider2D other)
    {
        bulletManager.ReturnBullet(gameObject);
    }

    //apply damage
    public int ApplyDamage()
    {
        return damage;
    }
}
