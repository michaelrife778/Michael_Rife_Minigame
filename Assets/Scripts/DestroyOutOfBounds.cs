using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float behindBound = -10f;
    public float forwardBound = 150f;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < behindBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z > forwardBound)
        {
            
            Destroy(gameObject);
        }
       
    }
}