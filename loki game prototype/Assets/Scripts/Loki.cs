using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loki : MonoBehaviour {
    static public Loki S;
    [Header("Set in Inspector")]

    public float speed = 30;
    public float rollMult = -45;
    public float PitchMult = 30;
    public float gameRestartDelay = 2f;
    public float JumpSpeed = 8f;
    public float gravity = 30f;
    private List<GameObject> projectiles = new List<GameObject>();
    public GameObject projectilePrefab;
    public Transform bulletSpawn;

    public float projectileSpeed = 40;
    [Header("Set dynamically")]
    [SerializeField]
    public float _sheildLevel = 1;

    private GameObject lastTriggerGo = null;

    void Awake()
    {
        if (S == null)
        {
            S = this;
        }
        else { 
        
        }
    }


    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos.x += xAxis * speed * Time.deltaTime;
        pos.y += yAxis * speed * Time.deltaTime;
        transform.position = pos;



        if (Input.GetKeyDown(KeyCode.Space))
        {
            TempFire();
        }
    }

  //  private void TempFire()
  //  {
   //     transform.position = new Vector3(transform.position.x + 0.2f, transform.position.y +0.305f, 0);
    //    GameObject projGo = Instantiate<GameObject>(projectilePrefab, transform.position, Quaternion.identity);
    //    projectiles.Add(projGo);
     //   Rigidbody rigidB = projGo.GetComponent<Rigidbody>();
     //   rigidB.velocity = Vector3.right * projectileSpeed;
   // }


    private void TempFire()
    {// Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
        projectilePrefab,
        bulletSpawn.position,
        bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.right * 6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }
}

