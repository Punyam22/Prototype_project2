using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables
    public float horizontalInput;
    public float speed= 30.0f;
    public float xRange= 20.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Keep player in bounds
        if(transform.position.x < -xRange)
        {
            transform.position= new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position= new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Launches the projectile
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        // Player controls
       horizontalInput= Input.GetAxis("Horizontal");
       transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput); 
    }
}
