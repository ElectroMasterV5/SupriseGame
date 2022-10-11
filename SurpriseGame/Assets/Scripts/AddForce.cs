using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public bool Open=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OpenDoor();
    }

    public void OpenDoor()
    {
        if (Open)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(10, 0, 10));
        }
        if (!Open)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(-10, 0, -10));
        }
    }
}
