using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanPlayerFollow : MonoBehaviour
{
    // Start is called before the first frame update
    Transform playerPosition;
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerPosition.position.x, 0, playerPosition.position.z) ;
    }
}
