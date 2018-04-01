using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class tesseractisfoundagain : MonoBehaviour {
    private int scene;
    private void OnCollisionEnter(Collision coll)
    {
        GameObject otherGO = coll.gameObject;
        if (otherGO.tag == "ProjectileHero")
        {
            Destroy(otherGO);
            Destroy(gameObject);
            SceneManager.LoadScene(scene);
            

        }
        else
        {
            print("Enemy hit by non-ProjectileHero: " + otherGO.name);
        }
    }
}
