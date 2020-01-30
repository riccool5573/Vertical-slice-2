﻿using UnityEngine.Audio;
using System;
using UnityEngine;

public class audioManager : MonoBehaviour
{

    public Sounds[] sound;
    // Start is called before the first frame update
    void Awake()
    {

        foreach (Sounds s in sound)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        Play("theme");
    }

    public void Play (string name)
    {
        Sounds s = Array.Find(sound, sounds => sounds.name == name);
        s.source.Play();
    }

    public void Stop (string name)
    {
        Sounds s = Array.Find(sound, sounds => sounds.name == name);
        s.source.Stop();
    }
}
