using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    //  This script is the same exact as the GameController script except this deals with only the music that plays in game.
    //  Refference the GameController script for my thought process.

    public AudioSource[] Piano;
    public AudioSource[] Beats;

    void Start()
    {
        //PIANO SECTION
        AudioSource pianoArray = Piano[Random.Range(0, Piano.Length)];
        AudioSource pianoSpawn = Instantiate (pianoArray);

        //BEATS SECTION
        AudioSource beatsArray = Beats[Random.Range(0, Piano.Length)];
        AudioSource beatsSpawn = Instantiate(beatsArray);

        print("Currently Playing :  " + " " + pianoArray + " " + beatsArray);
    }
}
