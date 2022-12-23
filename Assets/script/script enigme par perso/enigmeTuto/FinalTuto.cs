using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTuto : MonoBehaviour
{
    [SerializeField]
    GameObject Recompence;

    [SerializeField]
    GameObject okBoutton;

    public enigmeCondition enigmeCondition;

    public void Start()
    {
        Recompence.SetActive(false);

    }


    public void Final()
    {
        //Debug.Log("test");

        if(enigmeCondition.winPanel1 == true && enigmeCondition.winPanel2 == true && enigmeCondition.winPanel3 == true)
        {
            Recompence.SetActive(true);
            okBoutton.SetActive(true);
        }
    }

    public void OkButton()
    {
        //Debug.Log("test");
        okBoutton.SetActive(false);
        Recompence.SetActive(false);

        }
    


}
