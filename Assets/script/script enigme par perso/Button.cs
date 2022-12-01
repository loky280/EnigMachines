using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class Button : MonoBehaviour {

    [SerializeField]
    GameObject panel;

    [SerializeField]
    GameObject backBouton;

    [SerializeField]
    GameObject leftBouton;
    
    [SerializeField]
    GameObject rightBouton;


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

        panel.transform.Translate(27,0,0);
        
        }



        public void leftButton()
        {

        //Debug.Log("left");

        panel.transform.Translate(-27, 0, 0);
    }
 }

