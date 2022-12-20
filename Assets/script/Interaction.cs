using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;



public class Interaction : MonoBehaviour {

    //DialogueEtTuto dialogueEtTuto;

    // Variables
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

    Vector3 VectorCam;

    public float xTransform;
    public float yTransform;
    public float zTransform;
    public float position = 0;


    public void Start(){

        VectorCam = new Vector3(-183, -17, -58);

        enigme.SetActive(false);
        backButton.SetActive(false);
        leftButton.SetActive(false);
        rightButton.SetActive(false);
        okBoutton.SetActive(false);

    }


    public void Update(){
        RaycastHit hit;

        Camera camera = Camera.main;

        Debug.DrawRay(transform.position, Input.mousePosition , UnityEngine.Color.red);
        
        
        if(Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition),out hit)) {
            if (hit.transform.tag == "machiniste1")
            {
                //dialogueEtTuto.ActiveDialogue1.SetActive(true);
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

            }

            else if (hit.transform.tag == "Porte")
            {
                Debug.Log("porteExterieur");
              
                camera.transform.rotation = Quaternion.Euler(32, 0, 0);
                camera.transform.Translate(VectorCam * -1);
            }

        }


    }

    //_____________________Fonction Interessante

    //Debug.Log(hit.transform.name);_________donne l'information d'un objet hit par leraycast
    //gameObject.SetActive(false/true)______desative
    //Destroy(gameObject) _______detruit
    //gameObject.GetComponent<nomDuComponent>().enable = false/true; ______permet de modifier un component





}
