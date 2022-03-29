using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Look for a left mouse button click every frame.
        if (Input.GetMouseButtonDown(0))
        {
            // Convert mouse coordinates to world coordinates.
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Raycast from the camera and store the output in hitObject.
            RaycastHit2D hitObject = Physics2D.Raycast(worldPos, Vector2.zero);

            // Log a message if an object was hit or not.
            if (hitObject.collider != null)
            {
                Debug.Log("The user clicked on " + hitObject.collider.name);
            }
            else
            {
                Debug.Log("The user clicked on nothing.");
            }
        }
    }
}
