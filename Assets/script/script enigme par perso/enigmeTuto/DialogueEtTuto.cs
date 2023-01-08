using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEtTuto : MonoBehaviour
{
    public Interaction interaction;
    public Button button;

    public bool FinDialogue;

    //___________________UI-Dialogue ==> present ?
    [SerializeField]
    public bool disparue;

    public bool desactiveElipse;

    public bool debutDialogue;
    //public bool ActiveDialogue1;

    //public bool ActiveDialogue2;

    //public bool ActiveDialogue3;

    //public bool buttonPasserAutorisation;

    
    [SerializeField]
    GameObject buttonPasser;
    
    
    [SerializeField]
    GameObject pingPorte2;

    [SerializeField]
    GameObject elipse;

    //___________________Anna Qui parle
    [SerializeField]
    GameObject dialogueUI_1;

    //___________________Samuel Qui parle
    [SerializeField]
    GameObject dialogueUI_2;
    /*
    [SerializeField]
    GameObject dialoguepackage0;

    [SerializeField]
    GameObject dialoguepackage1;
    
    [SerializeField]
    GameObject dialoguepackage2;
    
    [SerializeField]
    GameObject dialoguepackage3;
    */

    //[SerializeField]
    //GameObject[] dialoguepackage;


    //__________________trad
    [SerializeField]
    GameObject textTuto2FR;

    [SerializeField]
    GameObject textTuto2EN;



    //__________________liste texte Francais
    [SerializeField]
    List<GameObject> dialoguepackage = new List<GameObject>();

    //__________________liste texte Englais
    [SerializeField]
    List<GameObject> dialoguepackageEN = new List<GameObject>();

   //________________dialogue precedent
    public int dialogue;
    
    //________________dialogue Actuelle
    public int dialogueMoinUn;


    // Start is called before the first frame update
    void Start()
    {

        //textTuto2FR.SetActive(false);
        //textTuto2EN.SetActive(false);

        desactiveElipse = false;
        //nomDeLaListe.Add(element1);
        //dialoguepackage.Add();
        //dialoguepackage.add
        //debutDialogue = false;
        //FinDialogue = false;
        dialogueMoinUn = 0;
        dialogue = 0;
        //buttonPasser.SetActive(false);
        //dialogueUI_1.SetActive(false);
        //dialoguepackage[0].SetActive(false);
        dialogueUI_2.SetActive(false);
        elipse.SetActive(false);
        
        textTuto2EN.SetActive(false);

        //_____________________________________________FR
        disparitionDialogue();
        dialoguepackage[0].SetActive(false);
        dialoguepackage[1].SetActive(false);
        dialoguepackage[2].SetActive(false);
        dialoguepackage[3].SetActive(false);
        dialoguepackage[4].SetActive(false);
        dialoguepackage[5].SetActive(false);
        
        dialoguepackage[6].SetActive(false);
        dialoguepackage[7].SetActive(false);
        dialoguepackage[8].SetActive(false);
        dialoguepackage[9].SetActive(false);
        dialoguepackage[10].SetActive(false);
        dialoguepackage[11].SetActive(false);
        
        dialoguepackage[12].SetActive(false);
        dialoguepackage[13].SetActive(false);
        dialoguepackage[14].SetActive(false);
        dialoguepackage[15].SetActive(false);
        dialoguepackage[16].SetActive(false);
        dialoguepackage[17].SetActive(false);
        dialoguepackage[18].SetActive(false);
        dialoguepackage[19].SetActive(false);
        dialoguepackage[20].SetActive(false);
        dialoguepackage[21].SetActive(false);
        dialoguepackage[22].SetActive(false);
        dialoguepackage[23].SetActive(false);
        dialoguepackage[24].SetActive(false);
        dialoguepackage[25].SetActive(false);
        dialoguepackage[26].SetActive(false);
        dialoguepackage[27].SetActive(false);
        dialoguepackage[28].SetActive(false);
        dialoguepackage[29].SetActive(false);


        //________________________________________EN
        dialoguepackageEN[0].SetActive(false);
        dialoguepackageEN[1].SetActive(false);
        dialoguepackageEN[2].SetActive(false);
        dialoguepackageEN[3].SetActive(false);
        dialoguepackageEN[4].SetActive(false);
        dialoguepackageEN[5].SetActive(false);

        dialoguepackageEN[6].SetActive(false);
        dialoguepackageEN[7].SetActive(false);
        dialoguepackageEN[8].SetActive(false);
        dialoguepackageEN[9].SetActive(false);
        dialoguepackageEN[10].SetActive(false);
        dialoguepackageEN[11].SetActive(false);

        dialoguepackageEN[12].SetActive(false);
        dialoguepackageEN[13].SetActive(false);
        dialoguepackageEN[14].SetActive(false);
        dialoguepackageEN[15].SetActive(false);
        dialoguepackageEN[16].SetActive(false);
        dialoguepackageEN[17].SetActive(false);
        dialoguepackageEN[18].SetActive(false);
        dialoguepackageEN[19].SetActive(false);
        dialoguepackageEN[20].SetActive(false);
        dialoguepackageEN[21].SetActive(false);
        dialoguepackageEN[22].SetActive(false);
        dialoguepackageEN[23].SetActive(false);
        dialoguepackageEN[24].SetActive(false);
        dialoguepackageEN[25].SetActive(false);
        dialoguepackageEN[26].SetActive(false);
        dialoguepackageEN[27].SetActive(false);
        dialoguepackageEN[28].SetActive(false);
        dialoguepackageEN[29].SetActive(false);



        //dialoguepackage1.SetActive(true);

        //buttonPasserAutorisation = true;
        //ActiveDialogue1 = false;
        //ActiveDialogue3 = false;
        //ActiveDialogue2 = false;
        //dialoguepackage0.SetActive(false);
        //dialoguepackage1.SetActive(false);
        //dialoguepackage2.SetActive(false);
        //dialoguepackage3.SetActive(false);
    }




    public void passageDeDialogueButton()
    {
        //dialogue précédent
        dialogueMoinUn = dialogue;
        
        //dialogue suivant
        dialogue += 1;

        //changement d'UIdialogue
        dialogueUI();
        
        if (desactiveElipse == true)
        {
            interaction.elipseStop();
        }

        if (dialogue <29 && button.langueFR == true )
        {
            //_______________________changement de dialogue precedent avec le suivant
            dialoguepackage[dialogueMoinUn].SetActive(false);
            dialoguepackage[dialogue].SetActive(true);
        
           
        }

        if (dialogue < 29 && button.langueFR == false)
        {
            //_______________________changement de dialogue precedent avec le suivant
            dialoguepackageEN[dialogueMoinUn].SetActive(false);
            dialoguepackageEN[dialogue].SetActive(true);


        }

        //___________________________________________condition de disparition des dialogue

        if (dialogue == 5 || dialogue == 6 || dialogue == 7 || dialogue == 8 || dialogue == 9 || dialogue == 10 || dialogue == 11 || dialogue == 12 || dialogue == 13 || dialogue == 19)
        {
            disparitionDialogue();
        }
       
       

        if (dialogue == 19)
        {
            disparitionDialogue();
            pingPorte2.SetActive(true);
            
            if (button.langueFR == false)
            {
                textTuto2FR.SetActive(false);
                textTuto2EN.SetActive(true);

            }
        }

       
        /*
        else if (debutDialogue == true)
        {
            apparitionDialogue();
        }
        */




    }

    public void elipseTiming()
    {

        if (dialogue == 20)
        {
            Debug.Log("test");
            dialogueUI_2.SetActive(false);
            dialogueUI_1.SetActive(false);
            elipse.SetActive(true);
        }
        //else elipse.SetActive(false);
        /*if (dialogue == 19)
       {
           elipse.SetActive(true);
           dialogueUI_2.SetActive(false);
           dialogueUI_1.SetActive(false);
           if (button.langueFR == true )
           {
               dialoguepackage[19].SetActive(true);
           }

           else { dialoguepackageEN[19].SetActive(true); }
       }

       else
       { 
           elipse.SetActive(false);
           dialoguepackage[19].SetActive(false);
           dialoguepackageEN[19].SetActive(false);

       }
       */
    }

    public void dialogueUI()
    {
        if (dialogue == 1 || dialogue == 14 || dialogue == 15 || dialogue == 18) { dialogueUI_2.SetActive(true); }

        else  { dialogueUI_2.SetActive(false); }
    }

    public void disparitionDialogue()
    {
        
        Debug.Log("disparition");
        disparue = true;
        buttonPasser.SetActive(false);
        dialogueUI_1.SetActive(false);
        
        
        if (button.langueFR == true)
        {
            dialoguepackage[dialogue].SetActive(false);
        }

      else
        {
            dialoguepackageEN[dialogue].SetActive(false);
        }
    }


    public void apparitionDialogue()
    {
       
        Debug.Log("apparition");
        disparue = false;
        buttonPasser.SetActive(true);
        dialogueUI_1.SetActive(true);
        
        if (button.langueFR == true)
        {
            dialoguepackage[dialogue].SetActive(true);
        }
        else
        {
            dialoguepackageEN[dialogue].SetActive(true);
        }

    }
    //public void passageDeDialogue (){

    //dialoguepackage1.SetActive(false);
    //}
    // Update is called once per frame



    public void changementLangue()
    {
        if (disparue == false) { 
            if (button.langueFR == true)
            {
                dialoguepackage[dialogue].SetActive(true);
                dialoguepackageEN[dialogue].SetActive(false);
            }
            else
            {
           
                dialoguepackage[dialogue].SetActive(false);
                dialoguepackageEN[dialogue].SetActive(true);
          
            }
        }
    }


    void Update()
    {
        
        
        /*
        if (dialogue == 3)
        {
            disparitionDialogue();
        }
        */

        //if (buttonPasserAutorisation == true)
        //{
        //buttonPasser.SetActive(true);

        //}
        //if dialogue =
        //dialoguepackage[dialogue].SetActive(true);



        /*
        if (dialogue == 0)
        {
            //passageDeDialogue();
            dialoguepackage[0].SetActive(true);
            
        }
        
        else if (dialogue == 1)
        {
            //passageDeDialogue();
            dialoguepackage[1].SetActive(true);

        }

        else if (dialogue == 2)
        {
            //passageDeDialogue();
            dialoguepackage[2].SetActive(true);

        }


        else if (dialogue == 3)
        {
            //passageDeDialogue();
            dialoguepackage[3].SetActive(true);

        }
        
        else if (dialogue == 4)
        {
            //passageDeDialogue();
            dialoguepackage[4].SetActive(true);

        }

        else if (dialogue == 5)
        {
            //passageDeDialogue();
            dialoguepackage[5].SetActive(true);

        }
        */
        /*
        //_____________________________________________________________
        if (ActiveDialogue1 == true)
        {
            //passageDeDialogue();
            dialoguepackage0.SetActive(true);
        }

        if (ActiveDialogue2 == true)
        {
            //passageDeDialogue();
            dialoguepackage2.SetActive(true);
        }

        if (ActiveDialogue3 == true)
        {
            //passageDeDialogue();
            dialoguepackage3.SetActive(true);
        }
        */
    }
}
