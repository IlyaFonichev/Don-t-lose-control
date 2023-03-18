using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed;
    private void Update()
    {
        speed = Input.GetAxis("Horizontal");
        transform.position += new Vector3(5, 0, 0) * speed * Time.deltaTime;
    }
}
