using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class essence : MonoBehaviour
{
    //enigmeCondition EnigmeEssence;

    [SerializeField]
    ParticleSystem particuleEssence;

    [SerializeField]
    GameObject jerican;

    [SerializeField]
    GameObject CheckJericanPosition;

    bool wasPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("test");

        //particuleEssence.SetActive(false);
      //  particuleEssence.Stop();

    }

    // Update is called once per frame

    void Update()
    {
        
        // Debug.Log(EnigmeEssence.Enremplissage);
        if (Vector3.Distance(jerican.transform.position, CheckJericanPosition.transform.position) < 3f && wasPlaying == false)
        {
            wasPlaying = true;

            Debug.Log("test");
            //   particuleEssence.SetActive(true);
            particuleEssence.Play();

        }

        if (Vector3.Distance(jerican.transform.position, CheckJericanPosition.transform.position) >= 3f && wasPlaying == true)
        {
            wasPlaying = false;

            particuleEssence.Stop();
            /*
             if (Vector3.Distance(particuleEssence.transform.position, CheckJericanPosition.transform.position) >= 3f)
            {
                //particuleEssence.SetActive(false);
                particuleEssence.Stop();

            }*/
        }
    }
}
