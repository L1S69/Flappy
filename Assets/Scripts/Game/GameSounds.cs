using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSounds : MonoBehaviour
{
    [SerializeField] private AudioSource backgroundMusic;
    [SerializeField] private AudioSource deathSound;
    [SerializeField] private SkinsData skinsData;

    private void Start()
    {
        deathSound.clip = skinsData.DeathSounds[PlayerPrefs.GetInt("ChoosedSkin")];
    }

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
