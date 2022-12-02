using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class Button : MonoBehaviour {

    public Transform panels;

    [SerializeField]
    GameObject panel;

    [SerializeField]
    GameObject backBouton;

    [SerializeField]
    GameObject leftBouton;
    
    [SerializeField]
    GameObject rightBouton;

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

    /*
        void Start()
        {
            Button btn = boutonback.GetComponent<Button>();____________creer un input de bouton
            btn.onClick.AddListener(backButton);
        }*/
    public void backButton()
    {

        //Debug.Log("back");

        panel.SetActive(false);
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
        panel.transform.Translate(27, 0, 0);
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

        panel.transform.Translate(-27, 0, 0);
    }
/*
    public void Update()
    {
        
    }
*/
}

