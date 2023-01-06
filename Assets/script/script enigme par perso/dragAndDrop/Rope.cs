using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
   
        public Transform cable;

        public LineRenderer rope;

    public Transform startPos;
        public LayerMask collMask;

        public List<Vector3> ropePositions { get; set; } = new List<Vector3>();

        bool isActive = false;



    float minCollisionDistance = 2f;




    private void Update()
    {
        rope.SetPosition(0, startPos.position);
        rope.SetPosition(1, cable.position);
    }

    /*
        private void Init()
        {

           AddPosToRope(startPos.position);

        isActive = true;

        }

        private void Update()
        {

            //ropePositions[0] = startPos.position;



            if(Input.GetKeyDown(KeyCode.K))
            {
                Init();
            }


        if (isActive == false)
            return;


            UpdateRopePositions();
            LastSegmentGoToPlayerPos();

            DetectCollisionEnter();
            if (ropePositions.Count > 2) DetectCollisionExits();

        }

        private void DetectCollisionEnter()
        {
            RaycastHit hit;
            if (Physics.Linecast(cable.position, rope.GetPosition(ropePositions.Count - 2), out hit, collMask))
            {

            // Check for duplicated collision (two collisions at the same place).

                if (System.Math.Abs(Vector3.Distance(rope.GetPosition(ropePositions.Count - 2), hit.point)) > minCollisionDistance)
                {

                    ropePositions.RemoveAt(ropePositions.Count - 1);

                    AddPosToRope(hit.point);

                }

            }
        }

        private void DetectCollisionExits()
        {
            RaycastHit hit;
            if (!Physics.Linecast(cable.position, rope.GetPosition(ropePositions.Count - 3), out hit, collMask))
            {
                ropePositions.RemoveAt(ropePositions.Count - 2);
            }
        }

        private void AddPosToRope(Vector3 _pos)
        {
            ropePositions.Add(_pos);
            ropePositions.Add(cable.position); //Always the last pos must be the player
        }

        private void UpdateRopePositions()
        {
            rope.positionCount = ropePositions.Count;
            rope.SetPositions(ropePositions.ToArray());
        }

        private void LastSegmentGoToPlayerPos() => rope.SetPosition(rope.positionCount - 1, cable.position);*/
}
