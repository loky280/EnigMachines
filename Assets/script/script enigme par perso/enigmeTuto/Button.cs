using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
//using UnityEditor.Presets;
using UnityEngine;
using UnityEngine.UI;
//using static UnityEngine.Rendering.DebugUI;


public class Button : MonoBehaviour {

    public constCondition const_Condition;

    // public Transform panels;


    public DialogueEtTuto dialogueEtTuto;

    public enigmeCondition enigmeCondition;

    [SerializeField]
    GameObject BoutonDemarrer;

    [SerializeField]
    GameObject elipse;

    //______________________________________________________

    [SerializeField]
    GameObject DragAndDropPanel1;

    [SerializeField]
    GameObject DragAndDropPanel2;

    [SerializeField]
    GameObject DragAndDropPanel3;

    [SerializeField]
    GameObject HelperPanel;

    [SerializeField]
    GameObject panel;

    //_____________________________________________________

    [SerializeField]
    GameObject DragAndDropPanelMino1;

    [SerializeField]
    GameObject DragAndDropPanelMino2;

    //[SerializeField]
    //GameObject DragAndDropPanelMino3;

    [SerializeField]
    GameObject HelperPanelMino;

    [SerializeField]
    GameObject panelMino;

    //________________________________________________________
    [SerializeField]
    GameObject Enigme;
  

    [SerializeField]
    GameObject menu;

    public bool langueFR;

    [SerializeField]
    GameObject indicateur1;
    
    [SerializeField]
    GameObject indicateur2;


    [SerializeField]
    GameObject backBouton;

    [SerializeField]
    GameObject leftBouton;
    
    [SerializeField]
    GameObject rightBouton;

    [SerializeField]
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
        langueFR = true;
        indicateur2.SetActive(false);
        menu.SetActive(false);
        
        DragAndDropPanel3.SetActive(false);
        DragAndDropPanel2.SetActive(false);
        DragAndDropPanel1.SetActive(true);


        //DragAndDropPanelMino3.SetActive(false);
        DragAndDropPanelMino2.SetActive(false);
        DragAndDropPanelMino1.SetActive(true);

        //VectorPanel = new Vector3(27, 0, 0);
        //Button btn = boutonback.GetComponent<Button>();____________creer un input de bouton
        //btn.onClick.AddListener(backButton);
    }

    
    public void backButton()
    {

        //Debug.Log("back");

        //dialogueEtTuto.disparitionDialogue();

        BoutonDemarrer.SetActive(false);
        HelperPanel.SetActive(false);
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
            
            gaucheDroite = 1;

            if (const_Condition.winConst == false) { 
               
                panel.transform.Translate(27, 0, 0);
            }

            else
            {
                panelMino.transform.Translate(27, 0, 0);
                //Debug.Log("ok");
            }


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
            gaucheDroite = 2;
            if (const_Condition.winConst == false)
            {

                panel.transform.Translate(-27, 0, 0);
            }

            else
            {
                panelMino.transform.Translate(-27, 0, 0);
                //Debug.Log("ok");
            }

        }
    }

    public void Menu_bouton()
    {
        menu.SetActive(true);
    
    }

    public void Menu_reprendre()
    {
        //Debug.Log("reprendre");
        menu.SetActive(false);

    }

    public void Menu_EN()
    {
        langueFR = false;
        indicateur1.SetActive(false);
        indicateur2.SetActive(true);
        dialogueEtTuto.changementLangue();
    }


    public void Menu_FR()
    {
        langueFR = true;
        indicateur1.SetActive(true);
        indicateur2.SetActive(false);
        dialogueEtTuto.changementLangue();
    }

    public void elipseStop()
    {
        elipse.SetActive(false);
    }

        void Update()
   {


        //____________________________________________________________________________enigmeTuto
        if (const_Condition.winConst == false)
        {
            if (Vector3.Distance(HelperPanel.transform.position, panel.transform.position) < 2f)
            {
                gaucheDroite = 0;
            }

            if (gaucheDroite == 0)
            {
                DragAndDropPanel3.SetActive(false);
                DragAndDropPanel2.SetActive(false);
                DragAndDropPanel1.SetActive(true);
            }

            //_______________________________________________________
            else if (gaucheDroite == 2)
            {
                if (dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue == 11) { dialogueEtTuto.apparitionDialogue(); }
                DragAndDropPanel3.SetActive(true);
                DragAndDropPanel2.SetActive(false);
                DragAndDropPanel1.SetActive(false);
            }

            //_______________________________________________________
            else if (gaucheDroite == 1)
            {

                if (dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue == 8 && enigmeCondition.winPanel1 == true) { dialogueEtTuto.apparitionDialogue(); }
                DragAndDropPanel3.SetActive(false);
                DragAndDropPanel2.SetActive(true);
                DragAndDropPanel1.SetActive(false);
            }
        }


        else
        {

            
            if (Vector3.Distance(HelperPanelMino.transform.position, panelMino.transform.position) < 2f)
            {
                gaucheDroite = 0;
            }

            if (gaucheDroite == 0)
            {
                //DragAndDropPanelMino3.SetActive(false);
                DragAndDropPanelMino2.SetActive(false);
                DragAndDropPanelMino1.SetActive(true);
            }

            //_______________________________________________________
            else if (gaucheDroite == 2)
            {
                //if (dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue == 11) { dialogueEtTuto.apparitionDialogue(); }
                //DragAndDropPanelMino3.SetActive(true);
                DragAndDropPanelMino2.SetActive(false);
                DragAndDropPanelMino1.SetActive(false);
            }

            //_______________________________________________________
            else if (gaucheDroite == 1)
            {
                //if (dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue == 8 && enigmeCondition.winPanel1 == true) { dialogueEtTuto.apparitionDialogue(); }
                //DragAndDropPanelMino3.SetActive(false);
                DragAndDropPanelMino2.SetActive(true);
                DragAndDropPanelMino1.SetActive(false);
            }
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

