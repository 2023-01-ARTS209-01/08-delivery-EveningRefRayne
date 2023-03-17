using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float moveSpeed=10;
    [SerializeField] private float turnSpeed=10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0) transform.Rotate(0, 0, -turnSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        if (Input.GetAxis("Vertical") != 0) transform.Translate(0, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0, Space.Self);
    }
}
