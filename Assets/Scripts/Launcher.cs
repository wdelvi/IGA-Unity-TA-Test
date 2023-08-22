using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public UIController uIController;
    public Transform spawnPoint;

    public float launchSpeed = 5f;
    public int numBalls = 10;

    // Start is called before the first frame update
    void Start()
    {
        if (uIController != null)
        {
            uIController.SetNumBalls(numBalls);
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePosition();
        UpdateSpawning();
    }

    private void UpdatePosition()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mousePosition.z = 0;

        Vector3 newPosition = transform.position;

        newPosition.x = mousePosition.y;

        transform.position = newPosition;
    }

    private void UpdateSpawning()
    {
        if(Input.GetMouseButtonDown(0) && numBalls > 0)
        {
            GameObject spawnedPrefab = Instantiate(prefabToSpawn, spawnPoint.transform.position, Quaternion.identity) as GameObject;
            Vector3 spawnVelocity = transform.up * -1f *  launchSpeed;
            spawnedPrefab.GetComponent<Rigidbody2D>().velocity = spawnVelocity;

            if(GetComponent<AudioSource>())
            {
                GetComponent<AudioSource>().Play();
            }

            numBalls--;

            if (uIController != null)
            {
                uIController.SetNumBalls(numBalls);
            }
        }
    }
}
