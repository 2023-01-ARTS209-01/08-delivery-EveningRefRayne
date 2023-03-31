using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private bool pickupState = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Hit: " + collision.gameObject.name);
        this.gameObject.GetComponent<Driver>().slowDown();
    }
    private void OnTriggerEnter2D(Collider2D trig)
    {
        //Debug.Log("Trigger: " + trig.gameObject.name);
        string trigTag = trig.gameObject.tag;
        if (trigTag == "Speeder") this.gameObject.GetComponent<Driver>().speedUp();
        if (trigTag == "Pickup" && pickupState == false)
        {
            pickupState = true;
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0.2f,0.4f,0.75f);//make it kinda blueish
            trig.gameObject.GetComponent<Pickup>().pick();
        }
        if (trigTag == "Dropoff" && pickupState == true)
        {
            pickupState = false;
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
