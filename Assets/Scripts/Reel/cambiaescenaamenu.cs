using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ReelTermina : MonoBehaviour
{
    public VideoPlayer video;

    private void Start()
    {
       
        if (video != null)
        {
            video.loopPointReached += OnVideoFinished; 
        }
        else
        {
            Debug.LogError("VideoPlayer no asignado en el Inspector.");
        }
    }

    private void OnVideoFinished(VideoPlayer vp)
    {
        SceneManager.LoadScene(0); 
 
    }

}
