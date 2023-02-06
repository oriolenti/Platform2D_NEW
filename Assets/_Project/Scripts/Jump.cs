using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float force = 10;
    public GameObject efectoSalto;
    Rigidbody2D rb;
    GroundDetector ground;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ground = GetComponent<GroundDetector>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ground.grounded == true && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, force));
            GameObject temp = Instantiate(efectoSalto, transform.position, transform.rotation);
            Destroy(temp, 1.5f);
        }
    }
}
