using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTrueGay : MonoBehaviour
{
    public bool Open = false;
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

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, 10f))
            {
                Debug.Log("Hit");
                if (raycastHit.transform.CompareTag("TrueDoor"))
                {
                    Debug.Log("Hit Door");
                    raycastHit.transform.GetComponent<OpenTrueGay>().SetOpen();
                }
            }
        }
        OpenTrueDoor();
    }
    public void SetOpen()
    {
        Open = !Open;
    }
    public void OpenTrueDoor()
    {
        if (Open)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 1));
        }
        if (!Open)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, -1));
        }
    }
}
