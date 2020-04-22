using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y); 
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y); 
        }
    }
}