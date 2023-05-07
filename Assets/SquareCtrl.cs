using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareCtrl : MonoBehaviour
{
    Rigidbody2D rigid2d;
    float jumpf;
    float maxjumpf = 800.0f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            this.jumpf += 60.0f;
        }

        if (Input.GetMouseButtonUp(0))
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
    }
}
