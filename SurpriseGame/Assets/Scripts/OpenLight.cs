using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLight : MonoBehaviour
{
    private Ray ray;
    public GameObject thisWorld;
    public GameObject LightHouse;
    public GameObject Player;
    public int MissionNum = 7;
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

                if (raycastHit.transform.CompareTag("Switch"))
                {
                    Player.GetComponent<QuestContoller>().setMissionNum(MissionNum);
                    thisWorld.SetActive(false);
                    LightHouse.SetActive(true);
                }

            }
        }
    }

}
