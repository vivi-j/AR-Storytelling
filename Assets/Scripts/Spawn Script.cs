using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject spherePrefab;
    private bool sphereSpawned = false;
    private Vector3 spawnPosition;

    void Update()
    {
        if (!sphereSpawned && Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10;
            spawnPosition = Camera.main.ScreenToWorldPoint(mousePos);
            GameObject newSphere = Instantiate(spherePrefab, spawnPosition, Quaternion.identity);
            Rigidbody rb = newSphere.GetComponent<Rigidbody>();
            newSphere.tag = "Sphere";
            sphereSpawned = true;
        }

        // change script to have it fall on the 2nd click
        
    }
}
