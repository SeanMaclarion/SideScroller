using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : Weapon
{

    public bool isActive = false;

    void Update()
    {
    }


    public override void Attack()
    {
        Shoot();
    }

    public override void GetPickedUp(Player player)
    {
        if (isActive)
        {
            return;
        }
        isActive = true;
        base.GetPickedUp(player);
        transform.localScale = new Vector3(.075f, .075f);
        transform.localPosition = new Vector3(.3f, -.1f);
    }

    
    public void Shoot()
    {
        //  Get a reference to all enemies
        var enemies = FindObjectsOfType<Enemy>();

        //  Loop through each enemy in the list
        foreach (var e in enemies)
        {

            //  Check if that enemy is within the sniper scope
            if ((e.transform.position.y < transform.position.y + 1) && (e.transform.position.y > transform.position.y - 1) && (e.transform.position.x > transform.position.x))
            {

                //  Set that enemy to NOT-Active
                e.gameObject.SetActive(false);
            }
        }

        //  Set myself (aka the gun) to NOT-Active. That way the sniper disappears, and can not be picked up again.
        gameObject.SetActive(false);
        Player.currentWeapon = null;
    }
}