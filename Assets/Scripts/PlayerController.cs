using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotatingSpeed;

    private float Vertical;
    private float Horizontal;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Vertical = Input.GetAxis("Vertical");
        this.Horizontal = Input.GetAxis("Horizontal");

        this.transform.Rotate(new Vector3(0, Horizontal * Time.deltaTime * speed, 0));

        this.transform.Translate(transform.forward * speed * Vertical * Time.deltaTime);
    }
}
