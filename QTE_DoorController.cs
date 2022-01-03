using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QTE_DoorController : MonoBehaviour
{

    private Animation anim;

    private int doorOpened = 0;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animation>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if ((Input.GetKey(KeyCode.Space)) && (doorOpened == 0))

            {
                anim.Play("QTE_Door_Open");
                doorOpened = 1;
            }
        }
        
    }

}
