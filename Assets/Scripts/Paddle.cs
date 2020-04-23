using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Paddle : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionY;
       
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y); 
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y); 
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}