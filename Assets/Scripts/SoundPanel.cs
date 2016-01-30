using UnityEngine;
using System.Collections;

public class SoundPanel : MonoBehaviour {

    public static SoundPanel sp = null;

    public AudioClip[] audioSelection;
    public AudioSource audioPlayer;

    public void Awake()
    {
        if(sp == null)
        {
            sp = this;
        }
        else if (sp != this)
        {
            DestroyObject(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    
    public void PlaySingle(int index)
    {
        audioPlayer.clip = audioSelection[index];
        audioPlayer.Play();     
    }

    public void PlaySingle(string name)
    {
        AudioClip selected = null;

        foreach(AudioClip au in audioSelection)
        {
            if(au.name == name)
            {
                selected = au;
                break;
            }
        }

        if (selected != null)
        {
            audioPlayer.clip = selected;
            audioPlayer.Play();
        }

    }


}
