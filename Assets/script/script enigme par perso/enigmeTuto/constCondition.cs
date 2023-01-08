using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class constCondition : MonoBehaviour
{
    //public Interaction interaction;


    [SerializeField]
    GameObject leftButton;

    [SerializeField]
    GameObject rightButton;

    [SerializeField]
    GameObject enigmeMino;

    [SerializeField]
    GameObject BoutonDemarrer;

    [SerializeField]
    GameObject dragandDropPlane;

    //__________________________________________

    [SerializeField]
    GameObject minotaure;

    [SerializeField]
    GameObject tete;

    [SerializeField]
    GameObject torse;

    [SerializeField]
    GameObject patteAvant;

    [SerializeField]
    GameObject patteArriere;

    [SerializeField]
    GameObject PTSEncrageMino1;

    [SerializeField]
    GameObject PTSEncrageMino2;

    [SerializeField]
    GameObject PTSEncrageMino3;

    [SerializeField]
    GameObject PTSEncrageMino4;

    public bool winConst;

    // Start is called before the first frame update
    void Start()
    {
        winConst = false;
        minotaure.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector3.Distance(tete.transform.position, PTSEncrageMino1.transform.position) < 2f) && (Vector3.Distance(torse.transform.position, PTSEncrageMino2.transform.position) < 2f) &&
        (Vector3.Distance(patteAvant.transform.position, PTSEncrageMino3.transform.position) < 2f) && (Vector3.Distance(patteArriere.transform.position, PTSEncrageMino4.transform.position) < 2f))
        {
            winConst = true;
            /*
            BoutonDemarrer.SetActive(true);
            enigmeMino.SetActive(true);
            leftButton.SetActive(true);
            rightButton.SetActive(true);
            */
            
            tete.SetActive(false);
            torse.SetActive(false);
            patteArriere.SetActive(false);
            patteAvant.SetActive(false);
            dragandDropPlane.SetActive(false);

            minotaure.SetActive(true);
            /*
                        if (dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue == 7)
                        {
                            dialogueEtTuto.apparitionDialogue();
                            Debug.Log("test");
                        }
            */

        }
    }
}
