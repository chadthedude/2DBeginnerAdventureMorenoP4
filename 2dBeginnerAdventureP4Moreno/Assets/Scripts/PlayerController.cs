using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.y = position.y + 0.05f;
        transform.position = position;

        Vector3 position1= transform.position;
        position.x = position.x + 0.05f;
        transform.position = position;

    }
}
