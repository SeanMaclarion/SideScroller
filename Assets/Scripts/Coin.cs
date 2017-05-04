using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Picked up coins");
        var player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            gameObject.GetComponent<Collider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            FindObjectOfType<GM>().SetPoints(FindObjectOfType<GM>().GetPoints() + 1);
        }
    }


}
