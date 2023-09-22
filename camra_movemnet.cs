using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camra_movement : MonoBehaviour
{
    public Transform TargetPosition;

    public Vector3 offset;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = TargetPosition.position + offset;

        newPosition.y = 0;
        newPosition.z = -10;
        transform.position = newPosition;
    }
}
