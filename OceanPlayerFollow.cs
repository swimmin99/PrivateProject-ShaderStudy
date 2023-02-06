using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oceanStat : MonoBehaviour
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
            transform.position = new Vector3(playerPosition.position.x, transform.position.y, playerPosition.position.z);
    }
}
