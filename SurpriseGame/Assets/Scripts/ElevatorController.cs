using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    // Start is called before the first frame update
    public int ElevatorPos = 0;
    public GameObject LeftFakeDoor;
    public GameObject RightFakeDoor;
    public GameObject Stairs;
    public GameObject Elevator;
    public bool ElevatorTriggered = false;
    public Animator ElevatorAnim;
    public Animator FakeDoorAnim;
    private Ray ray;
    public GameObject Player;
    public GameObject RedButton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ElevatorPos == 0)
        {
            LeftFakeDoor.SetActive(false);
            Stairs.SetActive(false);
            RightFakeDoor.SetActive(true);
        }
        if (ElevatorPos == 1)
        {
           
            RightFakeDoor.SetActive(false);
            AnimatorStateInfo stateinfo = ElevatorAnim.GetCurrentAnimatorStateInfo(0);  
            bool isClosing = stateinfo.IsName("CloseGate");
            bool isFixing = stateinfo.IsName("OpenGate");
            bool isClosed = stateinfo.IsName("Nothing");
            if (Elevator.GetComponent<Transform>().position.x < 2&&!isClosing&&!isFixing)
            {
                Elevator.GetComponent<Transform>().Translate(new Vector3(1, 0, 0) * Time.deltaTime / 3f);
                Player.GetComponent<CharacterController>().Move(new Vector3(1, 0, 0) * Time.deltaTime / 3f);
            }
            if (Elevator.GetComponent<Transform>().position.x >= 2)
            {
                ElevatorAnim.SetInteger("ElPos", 1);
                LeftFakeDoor.SetActive(true);
            }
            if (isClosed)
            {
                ElevatorPos = 2;
            }
        }
        if(ElevatorPos == 2)
        {
            LeftFakeDoor.SetActive(true);
            RightFakeDoor.SetActive(true);
            Stairs.SetActive(true);
            RedButton.GetComponent<OpenFake>().Now();
            Elevator.SetActive(false);
            
        }
        if (Input.GetMouseButton(0))
        {
           
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, 10f))
            {
                if (raycastHit.transform.CompareTag("Button")&&ElevatorPos==0)
                {
                    ElevatorAnim.SetBool("GateOpen", true);
                }
                if (raycastHit.transform.CompareTag("Button") && ElevatorPos == 2)
                {
                    Debug.Log("??");
                    FakeDoorAnim.SetBool("Open", true);
                }
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            ElevatorAnim.SetBool("GateOpen", false);
            ElevatorPos = 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
           
            ElevatorAnim.SetBool("Gate2Open", false);

        }
    }
}
