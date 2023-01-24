using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D)) rb.velocity = new Vector2(speed, rb.velocity.y);
        if (Input.GetKey(KeyCode.A)) rb.velocity = new Vector2(-speed, rb.velocity.y);
    }
}
