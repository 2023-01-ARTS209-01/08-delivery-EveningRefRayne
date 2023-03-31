using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    //All this does is turn itself off when the player sends it the message to do so.
    public void pick()
    {
        this.gameObject.SetActive(false);
    }
}
