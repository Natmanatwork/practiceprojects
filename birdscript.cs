using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{

    public Rigidbody2D birb;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        birb.velocity = Vector2.up * 10;
    }
}
