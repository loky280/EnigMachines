using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;



public class Interaction : MonoBehaviour {

    // Variables
    [SerializeField]
    GameObject panel;

    [SerializeField]
    GameObject backButton;

    [SerializeField]
    GameObject leftButton;
    
    [SerializeField]
    GameObject rightButton;

    public float xTransform;
    public float yTransform;
    public float zTransform;
    public float position = 0;
    //var entrerDansLeChamp = Vector3.Dot(rigidbody.velocity, transform.forward);
    //InteractionMachinisteTuto interactionMachinisteTuto;
    //public void selectionner() {

    //Debug.Log("test");

    //}

    public void Start(){
        
        panel.SetActive(false);
        backButton.SetActive(false);
        leftButton.SetActive(false);
        rightButton.SetActive(false);

    }


    public void Update(){
        RaycastHit hit;

        Camera camera = Camera.main;

        Debug.DrawRay(transform.position, Input.mousePosition , UnityEngine.Color.red);
        
        
        if(Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition),out hit)) {
            if (hit.transform.tag == "machiniste1") {

                panel.SetActive(true);
                backButton.SetActive(true);
                leftButton.SetActive(true);
                rightButton.SetActive(true);

                Debug.Log("machiniste1");
                

            }


        }

        //panel.transform.SetPositionAndRotation(xTransform, yTransform, zTransform);
       // panel.transform.Translate(xTransform, yTransform, zTransform);


       

      
        /*
        //aller a droite
        else if (position == 2)
        {
            xTransform = 10;
            yTransform = 0;
            zTransform = 0;

        }

        //aller a gauche
        else if (position == 3)
        {
            xTransform = -10;
            yTransform = 0;
            zTransform = 0;

        }
        */
            
            //_____________________Fonction Interessante

            //Debug.Log(hit.transform.name);_________donne l'information d'un objet hit par leraycast
            //gameObject.SetActive(false/true)______desative
            //Destroy(gameObject) _______detruit
            //gameObject.GetComponent<nomDuComponent>().enable = false/true; ______permet de modifier un component



        
    }
}
