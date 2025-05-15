using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform openSourceCameraLOL;
    public float scrollSpeed = 3f;
    public float dragSpeed = 2f;
    public float lowestY = 5f;
    public float highestY = 250f;

    public Vector3 initialPosition;
    public Vector3 pointBeforeII;

    float currentY;

    void Start() // fixing messed up camera
    {
        if (transform.position.y < lowestY || transform.position.y > highestY)
        {
            float adaptation = (highestY + lowestY) / 2;

            transform.position = new Vector3(0, adaptation, 0);
        }
    }

    void Update()
    {
        currentY = Camera.main.transform.position.y;

    // Scrolling
    float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 direct = transform.forward * scroll * scrollSpeed; // Direction we're going
        Vector3 newpos = transform.position + direct; // Where we want to go

        float camerasYCoord = (transform.position.y);
        if (newpos.y >= lowestY && newpos.y <= highestY)
        {
            transform.position = newpos;
        }
        else
        {
            Debug.Log("No. You can't do that.");
        }

        //tilt angles

        float deltaY = (currentY - lowestY);
        float tiltAngle = Mathf.Sqrt(3) * deltaY;

        Vector3 rotationWee = transform.localEulerAngles;
        rotationWee.x = 13;

        //Debug.Log(deltaY+","+tiltAngle+","+rotationWee.x);

        float distanceFromMin = initialPosition.y - lowestY;

        // Dragging
        float h = currentY / dragSpeed;

        if (Input.GetMouseButtonDown(2) || Input.GetMouseButtonDown(1))
        {
            pointBeforeII = Input.mousePosition;
        }

        if (Input.GetMouseButton(2))
        {
            Vector3 difference = (Input.mousePosition - pointBeforeII) * h * Time.deltaTime;
            transform.Translate(-difference.x, -difference.y, 0);
            pointBeforeII = Input.mousePosition;
        }
    }
}
