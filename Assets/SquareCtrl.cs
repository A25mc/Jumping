using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareCtrl : MonoBehaviour
{
    Rigidbody2D rigid2d;
    float jumpf;
    float maxjumpf = 600.0f;
    float warkf = 30.0f;
    float maxwalkspeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            this.jumpf += 50.0f;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (jumpf < this.maxjumpf)
            {
                this.rigid2d.AddForce(transform.up * this.jumpf);
                jumpf = 0;
            }
            else
            {
                this.rigid2d.AddForce(transform.up * this.maxjumpf);
                jumpf = 0;
            }
        }

        int direction = 0;
        if (Input.GetKey(KeyCode.A))
        {
            direction = -1;
        }
        
        float speedx=Mathf.Abs(this.rigid2d.velocity.x);

        if (speedx < this.maxwalkspeed)
        {
            this.rigid2d.AddForce(transform.right * direction * this.warkf);
        }
    }
}
