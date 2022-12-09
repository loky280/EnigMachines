using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEngine.EventSystems.PointerEventData;
using static UnityEngine.GraphicsBuffer;
using static UnityEngine.Rendering.DebugUI;

public class test : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
 

    public Transform anchor;

    [SerializeField]
    GameObject engrenageCasserCheck;

    [SerializeField]
    GameObject slot;

    //_________________transform du snap
    [SerializeField]
    Transform[] snapAnchors;

    //Vitesse du snap de l'objet au point d 'encrage
    [SerializeField]
    float snapSpeed = 10f;

    // vitesse de l'objet suivant la souris
    [SerializeField]
    float followSpeed = 10f;

    [SerializeField]
    float snapDistance = 1.5f;

    Camera cam;

    //derniere detection du recast
    Vector3 lastHitPos;


    

    void Start()
    {
        cam = Camera.main;
       
        lastHitPos = anchor.position;

    }

    
    void Update()
    {
        //__________________________Rend le drag and drop smooth
        /*
        //snap avec une certaine vitesse vers le point d'ancrage
        if (Vector3.Distance(lastHitPos, snapAnchor.position) < 2f)
        {
            //lerp = smooth
            anchor.position = Vector3.Lerp(anchor.position, snapAnchor.position, Time.deltaTime * snapSpeed);

        }
        else
        {
            //snap avec une certaine vitesse en dehors du point d'ancrage
            anchor.position = Vector3.Lerp(anchor.position, lastHitPos, Time.deltaTime * followSpeed);
        }
        */


        //S'il y a au moins une ancre de snap
        if(snapAnchors.Length >=1)
        {

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////             SNAP               ////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////

            Transform _closestAnchor = snapAnchors[0];
            float _smallestdistance = Vector3.Distance(lastHitPos, snapAnchors[0].position);

            //ON RECUPERE L'ANCRE LA PLUS PROCHE
            for (int i = 1; i < snapAnchors.Length; i++)
            {
                float _curdistance = Vector3.Distance(lastHitPos, snapAnchors[i].position) ;
                if (_curdistance < _smallestdistance)
                {
                    _smallestdistance = _curdistance;
                    _closestAnchor = snapAnchors[i];
                }
            }




            //snap avec une certaine vitesse vers le point d'ancrage
            if (_smallestdistance < snapDistance)
            {
                //lerp = smooth
                anchor.position = Vector3.Lerp(anchor.position, _closestAnchor.position, Time.deltaTime * snapSpeed);

            }
            else
            {
                //follow avec une certaine vitesse en dehors des points d'ancrage
                anchor.position = Vector3.Lerp(anchor.position, lastHitPos, Time.deltaTime * followSpeed);
            }


            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
        else
        {
            anchor.position = Vector3.Lerp(anchor.position, lastHitPos, Time.deltaTime * followSpeed);
        }

    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("oui-oui");
        
        
    }
    /*
    void OnBeginDrag(PointerEventData eventData)
    {

    }*/

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("babar");

    


        // la 6 em bit sera 1
        int layerMask = 1 << 6;


        RaycastHit hit;
        //_________________________________ Raycast pour donner la position de la souris
        if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(cam.ScreenPointToRay(Input.mousePosition).origin, cam.ScreenPointToRay(Input.mousePosition).direction * hit.distance, Color.yellow);
            //Debug.Log("Did Hit");

            lastHitPos = hit.point;
            
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("Casimir");
        
        if (engrenageCasserCheck.transform.tag == "engrenageCasser")
       {
          engrenageCasserCheck.SetActive(false);
        }

        if (engrenageCasserCheck.transform.tag == "Jerican")
        {
            //Debug.Log("jericanLacher");
            //engrenageCasserCheck.transform.position = Vector3.Lerp(anchor.position, slot.transform.position, Time.deltaTime * 40);
            lastHitPos = slot.transform.position;
            //anchor.position = Vector3.Lerp(anchor.position, snapAnchor.position, Time.deltaTime * snapSpeed);

        }

        //if (engrenageCasserCheck.transform.tag == "Jerican")
         //{

            

        //}
    }
}
