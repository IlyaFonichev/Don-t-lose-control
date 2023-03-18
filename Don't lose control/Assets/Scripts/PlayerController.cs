using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed;
    private float calmness;
    public static PlayerController instance;
    private void Start()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    public float getCalmness
    {
        get { return calmness; }
    }
    private void Update()
    {
        speed = Input.GetAxis("Horizontal");
        transform.position += new Vector3(5, 0, 0) * speed * Time.deltaTime;
    }
}
