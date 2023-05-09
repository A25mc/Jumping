using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Square");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos=this.player.transform.position;
        if (playerpos.x < 0)
        {
            transform.position = new Vector3(
                playerpos.x, transform.position.y, transform.position.z);
        }
    }
}
