using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;



public class Interaction : MonoBehaviour {

    public DialogueEtTuto dialogueEtTuto;

    public Button button;
    // Variables


    [SerializeField]
    GameObject interactionMino;

    [SerializeField]
    GameObject constructionMino;

    [SerializeField]
    GameObject elispeEn;

    [SerializeField]
    GameObject elipseFR;

    [SerializeField]
    GameObject elipse;

    //[SerializeField]
    //GameObject buttonPasser;

   [SerializeField]
    GameObject pingPorte;
    
    [SerializeField]
    GameObject pingPorte2;

    [SerializeField]
    GameObject enigmeTuto;

    [SerializeField]
    GameObject enigmeMino;

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

    Vector3 VectorMino;
 
    public float xTransform;
    public float yTransform;
    public float zTransform;
    public float position = 0;


    public void Start(){

        constructionMino.SetActive(false);

        pingPorte.SetActive(true);
        pingPorte2.SetActive(false);
        elipse.SetActive(false);
        elispeEn.SetActive(false);

        VectorCam = new Vector3(-183, -17, -58);
        
        VectorMino = new Vector3(-75, -17, 0);
        
        Camera camera = Camera.main;
        //camera.transform.Translate(VectorCam);
        //camera.transform.rotation = Quaternion.Euler(13, 41, 0);

        BoutonDemarrer.SetActive(false);
        enigmeTuto.SetActive(false);
        enigmeMino.SetActive(false);
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
                enigmeTuto.SetActive(true);
                backButton.SetActive(true);
                leftButton.SetActive(true);
                rightButton.SetActive(true);
                //porteButton.SetActive(false); 

                Debug.Log("machiniste1");
            }


            else if (hit.transform.tag == "machiniste3")
            {
                /*
                if (dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue == 5)
                {
                    dialogueEtTuto.apparitionDialogue();
                }*/

                camera.transform.rotation = Quaternion.Euler(13, 90, 0);
                camera.transform.Translate(VectorMino);

                constructionMino.SetActive(true);

                if ((dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue==19) || (dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue == 23) )
                {
                    dialogueEtTuto.apparitionDialogue();
                    dialogueEtTuto.dialogue = 23;
                }

                    //BoutonDemarrer.SetActive(true);
                    //enigmeMino.SetActive(true);
                    //backButton.SetActive(true);
                    //leftButton.SetActive(true);
                    //rightButton.SetActive(true);
                    //porteButton.SetActive(false); 
                    interactionMino.SetActive(false); 

                    Debug.Log("machiniste3");
            }

            else if (hit.transform.tag == "porteInterieur")
            {
                Debug.Log("porteInterieur");

                camera.transform.Translate(VectorCam);
                camera.transform.rotation = Quaternion.Euler(13, 41, 0);
                pingPorte2.SetActive(false);

                if (dialogueEtTuto.dialogue == 19) { 
                    //dialogueEtTuto.dialogue +=1;
                    //dialogueEtTuto.dialogueMoinUn += 1;
                    
                    elipse.SetActive(true);

                    if (button.langueFR == false) {
                    elispeEn.SetActive(true);
                    elipseFR.SetActive(false);

                    }
                    //buttonPasser.SetActive(true);
                    else;
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

                if (dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue == 19)
                {
                    dialogueEtTuto.apparitionDialogue();
                }
            }

        }


    }

    //_____________________Fonction Interessante

    //__________________position Interieur :  X=0    Y=12.1    Z=-10                rotation :  X=32

    //__________________position Exterieur :  X=-183    Y=28.4185    Z=-68.19542                rotation :  X=13    y=41
    //__________________positionMino : x= -192.9       y=11         z=8     rotation: x = 13 y= 90

    //Debug.Log(hit.transform.name);_________donne l'information d'un objet hit par leraycast
    //gameObject.SetActive(false/true)______desative
    //Destroy(gameObject) _______detruit
    //gameObject.GetComponent<nomDuComponent>().enable = false/true; ______permet de modifier un component





}
