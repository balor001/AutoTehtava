using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 offset;
    public Vector3 rotate;
    public GameObject FollowedObject;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the FollowedObjects position
        // Set this transform's position
        this.transform.position = FollowedObject.transform.position;
        this.transform.rotation = FollowedObject.transform.rotation;

        // Add the offset
        this.transform.Translate(offset);
        this.transform.Rotate(rotate);
    }
}
