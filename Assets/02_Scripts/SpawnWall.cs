using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    public GameObject upperWall, lowerWall;
    Vector3 upperWallPosition, lowerWallPosition;
    public float MaxY, MinY;
    // Start is called before the first frame update
    void Start()
    { 
        StartCoroutine(coSpawnWall());
        upperWallPosition = gameObject.transform.position;
        lowerWallPosition = upperWallPosition;

    }

    // Update is called once per frame
    void Update()
    {

        upperWallPosition.y = Random.Range(MaxY, MinY);
        lowerWallPosition.y = upperWallPosition.y - 20.0f;
    }

    IEnumerator coSpawnWall()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            Instantiate(upperWall, upperWallPosition, transform.rotation);
            Instantiate(lowerWall, lowerWallPosition, transform.rotation);
        }
    }
}
