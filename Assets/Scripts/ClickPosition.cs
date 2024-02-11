using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPosition : MonoBehaviour
{
    //public GameObject spherePrefab; // Reference to the sphere prefab to instantiate
    //private int count = 1; // Counter to track the number of clicks

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 -> left mouse button
        {
            // Get the click position in screen coordinates
            Vector3 clickPosition = Input.mousePosition;

            // Instantiate the sphere only on the first click
            /*if (count == 1)
            {
                Instantiate(spherePrefab, clickPosition, Quaternion.identity);
            }*/

            // Increment the count
            //count++;
            Debug.Log("Clicked at: " + clickPosition);
        }
    }
}
