using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSounds : MonoBehaviour
{
    [SerializeField] private AudioSource backgroundMusic;
    [SerializeField] private AudioSource deathSound;

    private void OnEnable()
    {
        GameEvents.GameOverAction += PlayDeathSound;
    }

    private void OnDisable()
    {
        GameEvents.GameOverAction -= PlayDeathSound;
    }

    private void PlayDeathSound() 
    {
        backgroundMusic.Stop();
        deathSound.Play();
    }
}
