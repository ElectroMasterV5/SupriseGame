using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class ChangeURL : MonoBehaviour
{
    
    VideoPlayer vidplayer;
    // Start is called before the first frame update
    void Start()
    {
        vidplayer = GetComponent<VideoPlayer>();

        vidplayer.url = Path.Combine(Application.streamingAssetsPath, "Rick.mp4");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
