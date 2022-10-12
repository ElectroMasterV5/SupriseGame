using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMission : MonoBehaviour
{
    public int MissionNum = 2;
    public GameObject Player;
    public GameObject Self;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.GetComponent<QuestContoller>().setMissionNum(MissionNum);
        }
        Destroy(Self);
    }
}
