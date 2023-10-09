using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public Vector3 mypos;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = mypos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
