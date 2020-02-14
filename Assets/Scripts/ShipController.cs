using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    // Variables
    public float speed;
    public float minX, minY, maxX, maxY;
    public GameObject laser;
    public GameObject laserSpawn;
    public float fireRate = 0.25f;

    private Rigidbody2D rBody;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Check if "fire" button is pressed
        if (Input.GetAxis("Fire1") > 0 && timer > fireRate)
        {
            //If yes, spawn laser
            GameObject go = GameObject.Instantiate(laser, laserSpawn.transform.position, laserSpawn.transform.rotation);
            go.transform.Rotate(new Vector3(0, 0, 90));

            //Reset timer
            timer = 0;
        }

        timer += Time.deltaTime;
    }
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        rBody.velocity = new Vector2(horiz, vert) * speed;

        // Restrict the play from leaving the play area
        rBody.position = new Vector2(Mathf.Clamp(rBody.position.x, minX, maxX),(Mathf.Clamp(rBody.position.y, minY, maxY)));
    }
}
