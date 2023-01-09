using System.Collections;
using System.Collections.Generic;
//using System.Media;
using UnityEngine;


public class son : MonoBehaviour
{
    public AudioSource sonAmbiance;
    public bool SonAmbianceActive ;
    // Start is called before the first frame update
    void Start()
    {
        sonAmbiance.Play();
        SonAmbianceActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
