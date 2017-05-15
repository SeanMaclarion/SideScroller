using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("On top of pipe");
        var player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            Debug.Log("Can go down");
            player.canGoDown = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exited pipe");
        var player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.canGoDown = false;
        }
    }
}