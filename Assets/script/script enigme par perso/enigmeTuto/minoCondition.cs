using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minoCondition : MonoBehaviour
{
    public Boolean winPanel1;
    public Boolean winPanel2;
    public Boolean winPanel3;

    //public Boolean Enremplissage;
    public DialogueEtTuto dialogueEtTuto;

    //_______________Green light
    [SerializeField]
    GameObject Greenlight1;

    [SerializeField]
    GameObject Greenlight2;

    [SerializeField]
    GameObject Greenlight3;

    //_______________Green and Red light bouton

    [SerializeField]
    GameObject GreenlightBouton1;

    [SerializeField]
    GameObject GreenlightBouton2;

    [SerializeField]
    GameObject GreenlightBouton3;

    [SerializeField]
    GameObject redlightBouton1;

    [SerializeField]
    GameObject redlightBouton2;

    [SerializeField]
    GameObject redlightBouton3;


    //====================================================< enigmetuto Panel 2>

    //_______________Prises
    [SerializeField]
    GameObject Prise1;

    [SerializeField]
    GameObject Prise2;

    [SerializeField]
    GameObject Prise3;

    [SerializeField]
    GameObject Prise4;

    [SerializeField]
    GameObject Prise5;



    //_______________Prises
    [SerializeField]
    GameObject cable1;

    [SerializeField]
    GameObject cable2;

    [SerializeField]
    GameObject cable3;

    [SerializeField]
    GameObject cable4;

    [SerializeField]
    GameObject cable5;
    //====================================================< enigmetuto Panel 3>

    [SerializeField]
    GameObject jerican;

    [SerializeField]
    GameObject CheckJericanPosition;

    [SerializeField]
    GameObject Liquide;

    public float essence = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Liquide.transform.localScale = new Vector3(6f, 3f, 0f);

        essence = 1;

        GreenlightBouton1.SetActive(false);
        GreenlightBouton2.SetActive(false);
        GreenlightBouton3.SetActive(false);
        Greenlight1.SetActive(false);
        Greenlight2.SetActive(false);
        Greenlight3.SetActive(false);
        winPanel1 = false;
    }


    // Update is called once per frame
    void Update()
    {

        //__________________________________win condition panel 2

        if ((Vector3.Distance(cable1.transform.position, Prise1.transform.position) < 2f) && (Vector3.Distance(cable2.transform.position, Prise2.transform.position) < 2f) &&
        (Vector3.Distance(cable3.transform.position, Prise3.transform.position) < 2f) && (Vector3.Distance(cable4.transform.position, Prise4.transform.position) < 2f))

        {
            winPanel2 = true;
            Greenlight2.SetActive(true);
            GreenlightBouton3.SetActive(true);
            redlightBouton3.SetActive(false);
            if (dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue == 9) { dialogueEtTuto.apparitionDialogue(); }
        }

        //__________________________________win condition panel 3


        if (Vector3.Distance(jerican.transform.position, CheckJericanPosition.transform.position) < 3f)
        {

            essence += 1 * Time.deltaTime;

            if (essence <= 8)
            {
                Liquide.transform.localScale = new Vector3(6f, 3f, essence / 4);
            }

            //Enremplissage = true;
            if (essence >= 8)
            {
                winPanel3 = true;
                Greenlight3.SetActive(true);
                GreenlightBouton1.SetActive(true);
                redlightBouton1.SetActive(false);
                if (dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue == 28) { dialogueEtTuto.apparitionDialogue(); }
            }

        }
    }

}
