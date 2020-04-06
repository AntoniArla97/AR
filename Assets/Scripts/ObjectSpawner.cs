using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    private PlacementIndicatorScript placementIndicatorScript;

    private void Start()
    {
        placementIndicatorScript = FindObjectOfType<PlacementIndicatorScript>();
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(objectToSpawn, placementIndicatorScript.transform.position, placementIndicatorScript.transform.rotation);
        }
    }

}
