using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] Piano;
    public AudioSource[] Beats;
    public AudioSource[] Spazaz; //Lack of a better term

    void Awake()
    {
        //PIANO SECTION
        AudioSource pianoArray = Piano[Random.Range(0, Piano.Length)];
        AudioSource pianoSpawn = Instantiate (pianoArray);

        //BEATS SECTION


        //SPAZAZ SECTION
    }
}
