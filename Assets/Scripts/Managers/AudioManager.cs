using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] Piano;
    public AudioSource[] Beats;
    public AudioSource[] Ambience;

    void Awake()
    {
        //PIANO SECTION
        AudioSource pianoArray = Piano[Random.Range(0, Piano.Length)];
        AudioSource pianoSpawn = Instantiate (pianoArray);

        //BEATS SECTION


        //AMBIENCE SECTION

    }
}
