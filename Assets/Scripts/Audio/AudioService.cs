using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using SkyForce.Generics;

namespace SkyForce.Audio
{
    public enum SoundTag
    {
        ExplosionEffect,
        BulletFiring
    }

    [System.Serializable]
    public class GameSound
    {
        public SoundTag soundTag;
        public bool loop;
        public AudioClip audioClip;
        [Range(0f, 1f)]
        public float volume;
        [Range(0.1f, 3.0f)]
        public float pitch;
        
        [HideInInspector]
        public AudioSource audioSource;
    }

    public class AudioService : GenericMonoSingleton<AudioService>
    {
        [SerializeField]
        private GameSound[] SoundsList;
        private void Awake() 
        {
            base.Awake();
            foreach(GameSound s in SoundsList)
            {
                s.audioSource = gameObject.AddComponent<AudioSource>();
                s.audioSource.clip = s.audioClip;
                s.audioSource.loop = s.loop;
                s.audioSource.volume = s.volume;
                s.audioSource.pitch = s.pitch;
            }

        }

        public void PlaySound(SoundTag audioTag)
        {
            GameSound s = Array.Find(SoundsList, Sound => Sound.soundTag == audioTag);
            if (s == null)
            {
                Debug.LogWarning("Audio missing!!!!!");
			    return;
            }
            s.audioSource.Play();
        }
    }
}
