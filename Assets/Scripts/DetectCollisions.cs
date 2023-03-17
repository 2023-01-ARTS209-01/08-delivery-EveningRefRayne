using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit: " + collision.gameObject.name);
        this.gameObject.GetComponent<Driver>().slowDown();
    }
    private void OnTriggerEnter2D(Collider2D trig)
    {
        Debug.Log("Trigger: " + trig.gameObject.name);
        this.gameObject.GetComponent<Driver>().speedUp();
    }
}
