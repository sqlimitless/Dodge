using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRigidbody;
    public float speed = 8f;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 vector3 = new Vector3(xSpeed,0,zSpeed);

        playerRigidbody.velocity = vector3;
    }

    public void Die(){
        gameManager.GameOver();
        gameObject.SetActive(false);
    }
}
