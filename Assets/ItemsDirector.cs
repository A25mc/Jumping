using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsDirector : MonoBehaviour
{
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("HIT");
        }

        if (collision.gameObject.tag == "Floor")
        {
            Destroy(gameObject);
        }
    }
}
