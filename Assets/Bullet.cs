using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 8;
    private Rigidbody bulletRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = speed * transform.forward;
        Destroy(gameObject,5);
    }

    void OnTriggerEnter(Collider collider){
        if(collider.tag == "Player"){
            PlayerController playerController = collider.GetComponent<PlayerController>();
            if(playerController != null){
                playerController.Die();
            }
        }
    }
}
