using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;



public class Interaction : MonoBehaviour {

    public DialogueEtTuto dialogueEtTuto;

    // Variables



    [SerializeField]
    GameObject elipse;
        
    [SerializeField]
    GameObject pingPorte;
    
    [SerializeField]
    GameObject pingPorte2;

    [SerializeField]
    GameObject enigme;

    [SerializeField]
    GameObject okBoutton;

    [SerializeField]
    GameObject backButton;

    [SerializeField]
    GameObject leftButton;
    
    [SerializeField]
    GameObject rightButton;

    [SerializeField]
    GameObject porteButton;

    [SerializeField]
    GameObject BoutonDemarrer;

    Vector3 VectorCam;

    public float xTransform;
    public float yTransform;
    public float zTransform;
    public float position = 0;


    public void Start(){

        pingPorte.SetActive(true);
        pingPorte2.SetActive(false);
        elipse.SetActive(false);

        VectorCam = new Vector3(-183, -17, -58);
        
        Camera camera = Camera.main;
        //camera.transform.Translate(VectorCam);
        //camera.transform.rotation = Quaternion.Euler(13, 41, 0);

        BoutonDemarrer.SetActive(false);
        enigme.SetActive(false);
        backButton.SetActive(false);
        leftButton.SetActive(false);
        rightButton.SetActive(false);
        okBoutton.SetActive(false);

    }

    public void elipseStop()
    {
        elipse.SetActive(false);
    }

    public void Update(){
        RaycastHit hit;

        Camera camera = Camera.main;

        Debug.DrawRay(transform.position, Input.mousePosition , UnityEngine.Color.red);
        
        
        if(Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition),out hit)) {
            if (hit.transform.tag == "machiniste1")
            {

                if (dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue == 5)
                {
                    dialogueEtTuto.apparitionDialogue();
                }

                BoutonDemarrer.SetActive(true);
                enigme.SetActive(true);
                backButton.SetActive(true);
                leftButton.SetActive(true);
                rightButton.SetActive(true);
                //porteButton.SetActive(false); 

                Debug.Log("machiniste1");
            }

            else if (hit.transform.tag == "porteInterieur")
            {
                Debug.Log("porteInterieur");

                camera.transform.Translate(VectorCam);
                camera.transform.rotation = Quaternion.Euler(13, 41, 0);
                pingPorte2.SetActive(false);

                if (dialogueEtTuto.dialogue == 19) { 
                    dialogueEtTuto.dialogue +=1;
                    dialogueEtTuto.dialogueMoinUn += 1;
                    elipse.SetActive(true);
                }

            }

            else if (hit.transform.tag == "Porte")
            {
                Debug.Log("porteExterieur");

                pingPorte.SetActive(false);
                camera.transform.rotation = Quaternion.Euler(32, 0, 0);
                camera.transform.Translate(VectorCam * -1);

                if (dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue == 0) { 
                    dialogueEtTuto.apparitionDialogue();
                }
            }

        }


    }

    //_____________________Fonction Interessante

    //__________________position Interieur :  X=0    Y=12.1    Z=-10                rotation :  X=32

    //__________________position Exterieur :  X=-183    Y=28.4185    Z=-68.19542                rotation :  X=32

    //Debug.Log(hit.transform.name);_________donne l'information d'un objet hit par leraycast
    //gameObject.SetActive(false/true)______desative
    //Destroy(gameObject) _______detruit
    //gameObject.GetComponent<nomDuComponent>().enable = false/true; ______permet de modifier un component





}
