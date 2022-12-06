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

    //_________________transform du snap
    [SerializeField]
    Transform snapAnchor;

    //Vitesse du snap de l'objet au point d 'encrage
    [SerializeField]
    float snapSpeed = 10f;

    // vitesse de l'objet suivant la souris
    [SerializeField]
    float followSpeed = 10f;

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


    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("oui-oui");
        
        
    }
    /*
    void OnBeginDrag(PointerEventData eventData)
    {

    }*/

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("babar");

    


        // la 6 em bit sera 1
        int layerMask = 1 << 6;


        RaycastHit hit;
        //_________________________________ Raycast pour donner la position de la souris
        if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(cam.ScreenPointToRay(Input.mousePosition).origin, cam.ScreenPointToRay(Input.mousePosition).direction * hit.distance, Color.yellow);
            Debug.Log("Did Hit");

            lastHitPos = hit.point;
            
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Casimir");
        
        if (engrenageCasserCheck.transform.tag == "engrenageCasser")
       {
          engrenageCasserCheck.SetActive(false);
        }


    }
}
