using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public bool Open=false;
    private Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("I pushed!");
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, 10f))
            {
                Debug.Log("I Hit Something! "+ raycastHit.transform.tag);
                if (raycastHit.transform.CompareTag("Door"))
                {
                    Debug.Log("It's Door!");
                    raycastHit.transform.GetComponent<AddForce>().SetOpen();
                }
                
            }
        }
        OpenDoor();
    }

    public void OpenDoor()
    {
        if (!Open)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 1));
        }
        if (Open)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, -1));
        }
    }
    public void SetOpen()
    {
        Open = !Open;
    }
}
