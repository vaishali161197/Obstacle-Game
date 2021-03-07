using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgyHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(" Bumped into wall : " + collision.gameObject.name);
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
