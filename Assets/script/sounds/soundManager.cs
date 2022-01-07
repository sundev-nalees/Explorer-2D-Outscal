using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    private static soundManager instance;
    public static soundManager Instance { get { return instance; } }

    public AudioSource soundEffect;
    public AudioSource soundMusic;
    public SoundType[] sounds;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
    private void Start()
    {
        PlayMusic(Sounds.Music);
    }
    public void PlayMusic(Sounds sound) 
    {
        AudioClip clip = getSoundClip(sound);
        if (clip != null)
        {
            soundMusic.clip = clip;
            soundMusic.Play();

        }
        else
        {
            Debug.LogError("clip not found for sound type:" + sound);

        }

    }
    public void Play(Sounds sound)
    {
        AudioClip clip = getSoundClip(sound);
        if (clip != null)
        {
            soundEffect.PlayOneShot(clip);

        }
        else
        {
            Debug.LogError("clip not found for sound type:" + sound);

        }

    }

    private AudioClip getSoundClip(Sounds sound)
    {
        SoundType item = Array.Find(sounds, i => i.soundType == sound);
        if (item != null)
        {
            return item.SoundClip;
        }
        return null;
    }
    

    
}
[Serializable]
public class SoundType
{
    public Sounds soundType;
    public AudioClip SoundClip;
}
public enum Sounds
{
    ButtonClick,
    Music,
    PlayerMovement,
    PlayerDeath,
    EnwmyDeath,
}