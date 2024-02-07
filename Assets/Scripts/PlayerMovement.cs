using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    //Store Player's direction
    public float moveDirectionX = 0;
    public float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     moveDirectionX = Input.GetAxisRaw("Horizontal");
     Debug.Log(moveDirectionX);
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2(
        moveDirectionX * moveSpeed,
        rb.velocity.y);
    }
}