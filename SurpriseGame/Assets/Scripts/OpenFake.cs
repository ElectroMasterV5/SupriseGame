using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFake : MonoBehaviour
{
    public GameObject RightFakeDoor;
    public Animator FakeDoorAnim;
    private Ray ray;
    public GameObject Stairs;
    public bool canDo = false;
    public GameObject Light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)&&canDo)
        {
            
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, 10f))
            {
               
                if (raycastHit.transform.CompareTag("Button"))
                {
                    Debug.Log("The light should be open");
                    FakeDoorAnim.SetBool("Open", true);
                    Light.SetActive(true);
                }
            }
        }
    }
    public void Now()
    {
        canDo = true;
    }
}
