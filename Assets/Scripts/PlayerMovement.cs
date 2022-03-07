using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;

       // Update is called once per frame
       // This part of the code, is what makes the Player move around the place with a mouse input. 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; 

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }

        if(agent.isOnOffMeshLink)
        {
            agent.CompleteOffMeshLink();
        }
    }
}
