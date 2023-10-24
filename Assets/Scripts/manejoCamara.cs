using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manejoCamara : MonoBehaviour
{
    public Transform objetoASeguir;
    public float offset;

    private void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x,transform.position.y,objetoASeguir.position.z + offset);

    }
}
