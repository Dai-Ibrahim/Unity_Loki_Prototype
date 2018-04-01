using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
    static public bool goalMet = false;
    public GameObject tesseractPrefab;
    private void OnCollisionEnter(Collision coll)
    {
        GameObject otherGO = coll.gameObject;
        if (otherGO.tag == "ProjectileHero")
        {
            Destroy(otherGO);
            Destroy(gameObject);
            goalMet = true;
            var position = new Vector3(Random.Range(-7,35f),Random.Range(0, 8.5f),0 );
            var tesseract = (GameObject)Instantiate(tesseractPrefab, position, Quaternion.identity);

        }
        else
        {
            print("Enemy hit by non-ProjectileHero: " + otherGO.name);
        }
    }


}
