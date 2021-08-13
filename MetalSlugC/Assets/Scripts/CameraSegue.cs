using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSegue : MonoBehaviour
{

    public Transform target;

    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
}
