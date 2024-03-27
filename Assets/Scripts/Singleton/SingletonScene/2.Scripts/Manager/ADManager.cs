using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADManager : MonoBehaviour
{
    private static ADManager instance = null;
    public static ADManager Instance
    {
        get 
        { 
            if (instance == null)
                instance = new ADManager();
            return instance; 
        }
    }
    void Start()
    {
        if (instance == null)
            instance = this;
    }

    int point = 0;
    
    public void Play(AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }

    public int getPoint() => point++;

}
