using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMashTest : MonoBehaviour
{
    public NavMeshAgent nav;
    public Transform target;
// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   
    {
        nav.SetDestination(target.position);
        for(int i = 0; i< nav.path.corners.Length-1; i++)
        {
            Debug.DrawLine(nav.path.corners[i], nav.path.corners[i+1], Color.red);
          //  nav.
        }
        
    }
}
