using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    private void OnCollisionEnter(Collision coll)
    {
        GameObject otherGO = coll.gameObject;
        if (otherGO.tag == "ProjectileHero")
        {
            Destroy(otherGO);
            Destroy(gameObject);

        }
        else
        {
            print("Enemy hit by non-ProjectileHero: " + otherGO.name);
        }
    }
}
