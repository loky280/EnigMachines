using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enigme_condition : MonoBehaviour
{
    public Boolean winPanel1;
    public Boolean winPanel2;
    public Boolean winPanel3;

//====================================================< enigmetuto Panel 1>
//_______________Point d'ancrage
    [SerializeField]
    GameObject PTSEncrage1;

    [SerializeField]
    GameObject PTSEncrage2;

    [SerializeField]
    GameObject PTSEncrage3;

    //_______________Engrenage    
    [SerializeField]
    GameObject engrenage1;
    
    [SerializeField]
    GameObject engrenage2;

    [SerializeField]
    GameObject GrosEngrenage1;

    //_______________Green light
    [SerializeField]
    GameObject Greenlight1;

    [SerializeField]
    GameObject Greenlight2;

    [SerializeField]
    GameObject Greenlight3;

    //_______________mise en place

    [SerializeField]
    GameObject engrenageCasser;

    //====================================================< enigmetuto Panel 2>

    //_______________Prises
    [SerializeField]
    GameObject Prise1;

    [SerializeField]
    GameObject Prise2;

    [SerializeField]
    GameObject Prise3;

    [SerializeField]
    GameObject Prise4;
    


    //_______________Prises
    [SerializeField]
    GameObject cable1;

    [SerializeField]
    GameObject cable2;

    [SerializeField]
    GameObject cable3;

    [SerializeField]
    GameObject cable4;

 


    // Start is called before the first frame update
    void Start()
    {
        //VectorEngrenageCasser = new Vector3(0, -17, -58);

        engrenageCasser.transform.position = Vector3.Lerp(engrenageCasser.transform.position, PTSEncrage1.transform.position,50f);

        Greenlight1.SetActive(false);
        Greenlight2.SetActive(false);
        Greenlight3.SetActive(false);
        winPanel1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        //__________________________________win condition panel 1
        
        if ((Vector3.Distance(engrenage1.transform.position, PTSEncrage1.transform.position) < 2f) && (Vector3.Distance(engrenage2.transform.position, PTSEncrage2.transform.position) < 2f) &&
         (Vector3.Distance(GrosEngrenage1.transform.position, PTSEncrage3.transform.position) < 2f))
        {
            winPanel1 = true;
            Greenlight1.SetActive(true);
        }



        if ((Vector3.Distance(engrenage2.transform.position, PTSEncrage1.transform.position) < 2f) && (Vector3.Distance(engrenage1.transform.position, PTSEncrage2.transform.position) < 2f) &&
         (Vector3.Distance(GrosEngrenage1.transform.position, PTSEncrage3.transform.position) < 2f))
        {
            winPanel1 = true;
            Greenlight1.SetActive(true);
        }

        //__________________________________win condition panel 2

        if ((Vector3.Distance(cable1.transform.position,Prise1.transform.position) < 2f) && (Vector3.Distance(cable2.transform.position, Prise2.transform.position) < 2f) &&
        (Vector3.Distance(cable3.transform.position, Prise3.transform.position) < 2f) && (Vector3.Distance(cable4.transform.position, Prise4.transform.position) < 2f))

        {
            winPanel1 = true;
            Greenlight2.SetActive(true);
        }


        //__________________________________win condition panel 2
        //if (Vector3.Distance(engrenage1.transform.position,PTSEncrage1.transform.position)< 2f){

        //Debug.Log("prout");
        //winPanel1 = true;
        //Greenlight1.SetActive(true);
        //}
    }
}

