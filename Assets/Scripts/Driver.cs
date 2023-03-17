using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float baseMoveSpeed=10;
    [SerializeField] private float baseTurnSpeed=10;
    private float currentMoveSpeed;
    private float currentTurnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        currentMoveSpeed= baseMoveSpeed;
        currentTurnSpeed= baseTurnSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0) transform.Rotate(0, 0, -currentTurnSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        if (Input.GetAxis("Vertical") != 0) transform.Translate(0, currentMoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0, Space.Self);
    }

    public void speedUp()
    {
        currentMoveSpeed = baseMoveSpeed * 1.25f;
        currentTurnSpeed = baseTurnSpeed * 1.15f;
    }

    public void slowDown()
    {
        currentMoveSpeed = baseMoveSpeed;
    }
}
