using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject ballObj;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = ballObj.transform.position;
        //newPosition.z -= 10.0f;
        if (gameObject.transform.position != newPosition)
        {
            //animator.SetBool("Running", true);
            Vector3 orientation = ballObj.transform.position - gameObject.transform.position;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, newPosition,
                                   0.2f);
            gameObject.transform.rotation = Quaternion.LookRotation(orientation);
        } else
        {
            //animator.SetBool("Running", false);
        }
    }
}
