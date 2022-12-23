using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
//using UnityEditor.Presets;
using UnityEngine;
using UnityEngine.UI;
//using static UnityEngine.Rendering.DebugUI;


public class Button : MonoBehaviour {

    // public Transform panels;

    //public DialogueEtTuto dialogueEtTuto;



    [SerializeField]
    GameObject DragAndDropPanel1;

    [SerializeField]
    GameObject DragAndDropPanel2;

    [SerializeField]
    GameObject DragAndDropPanel3;

    [SerializeField]
    GameObject HelperPanel;

    
    [SerializeField]
    GameObject Enigme;

    [SerializeField]
    GameObject panel;

    [SerializeField]
    GameObject backBouton;

    [SerializeField]
    GameObject leftBouton;
    
    [SerializeField]
    GameObject rightBouton;


    public int gaucheDroite;
    //Vector3 VectorPanel;
    /*
    [SerializeField]
    Transform snapAnchor;

    //Vitesse du snap de l'objet au point d 'encrage
    [SerializeField]
    float snapSpeed = 10f;

    // vitesse de l'objet suivant la souris
    [SerializeField]
    float followSpeed = 10f;
    
    [SerializeField]
    float positiondroite = 27;
    */

    
        void Start()
        {

        gaucheDroite = 0;
        
        
        DragAndDropPanel3.SetActive(false);
        DragAndDropPanel2.SetActive(false);
        DragAndDropPanel1.SetActive(true);
         
        //VectorPanel = new Vector3(27, 0, 0);
        //Button btn = boutonback.GetComponent<Button>();____________creer un input de bouton
        //btn.onClick.AddListener(backButton);
    }

    
    public void backButton()
    {

        //Debug.Log("back");

        //dialogueEtTuto.disparitionDialogue();


        Enigme.SetActive(false);
        //panel.SetActive(false);
        backBouton.SetActive(false);
        rightBouton.SetActive(false);
        leftBouton.SetActive(false);
    }


        public void rightButton()
        {

        

        //Debug.Log("right");
        //panels.position = Vector3.Lerp(panel.transform.Translate(27, 0, 0)), Time.deltaTime * snapSpeed);

        //panels.position = Vector3.Lerp.(panel.transform.Translate(27,0,0), Time.deltaTime* snapSpeed);
        //positiondroite = Lerp.(0, 27, Time.deltaTime * snapSpeed);

        if (gaucheDroite != 1){ 
            panel.transform.Translate(27, 0, 0);
            gaucheDroite = 1;
            
            //dialogueEtTuto.ActiveDialogue2 = true;
            //dialogueEtTuto.buttonPasserAutorisation = true;

            /*
                       DragAndDropPanel1.SetActive(false);
                       DragAndDropPanel2.SetActive(true);

                    }

                    else
                    {
                        DragAndDropPanel2.SetActive(false);
                       */
        }
        //panel.transform.position = Vector3.Lerp.(panel.transform.position, VectorPanel, 10f);


    }
   /*
   panel.position = Vector3.Lerp(panel.position, panel.position.x=+27, Time.deltaTime* snapSpeed);

       }
       else
{
   //snap avec une certaine vitesse en dehors du point d'ancrage
   anchor.position = Vector3.Lerp(anchor.position, lastHitPos, Time.deltaTime * followSpeed);
   */
            public void leftButton()
        {

        //Debug.Log("left");
        if (gaucheDroite != 2)
        {
            //dialogueEtTuto.ActiveDialogue3 = true;
            //dialogueEtTuto.buttonPasserAutorisation = true;

            gaucheDroite = 2;
            panel.transform.Translate(-27, 0, 0);
        }

   }



   void Update()
   {

       if (Vector3.Distance(HelperPanel.transform.position,panel.transform.position)<2f)
        { 
            gaucheDroite = 0;
        }

       if (gaucheDroite == 0) { 
        DragAndDropPanel3.SetActive(false);
        DragAndDropPanel2.SetActive(false);
        DragAndDropPanel1.SetActive(true);
        }

        //_______________________________________________________
        else if (gaucheDroite == 2) 
        { 
            DragAndDropPanel3.SetActive(true);
            DragAndDropPanel2.SetActive(false);
            DragAndDropPanel1.SetActive(false);
        }

        //_______________________________________________________
        else if (gaucheDroite == 1)
        {
            DragAndDropPanel3.SetActive(false);
            DragAndDropPanel2.SetActive(true);
            DragAndDropPanel1.SetActive(false);
        }
     

        //VectorPanel = new Vector3(27, 0, 0);
        //Button btn = boutonback.GetComponent<Button>();____________creer un input de bouton
        //btn.onClick.AddListener(backButton);
    }
   /*
       public void Update()
       {

       }
   */
}

