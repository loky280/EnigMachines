using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BackButton : MonoBehaviour
{

    [SerializeField]
    GameObject panel;

    [SerializeField]
    GameObject backBouton;

/*
    void Start()
    {
        Button btn = boutonback.GetComponent<Button>();____________creer un input de bouton
        btn.onClick.AddListener(backButton);
    }*/
     public void backButton()
    {

        Debug.Log("back");

        panel.SetActive(false);
        backBouton.SetActive(false);

    }
}
