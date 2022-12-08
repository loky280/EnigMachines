using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTuto : MonoBehaviour
{
    [SerializeField]
    GameObject Recompence;
    

    public enigmeCondition enigmeCondition;
    
    
    
    public void Final()
    {
        Debug.Log("test");

        if(enigmeCondition.winPanel1 == true && enigmeCondition.winPanel2 && enigmeCondition.winPanel3)
        {
            Recompence.SetActive(true);

        }
    }

   
}
