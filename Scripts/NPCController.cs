using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{


    //public int npcMovementSpeed = 3; 
    private Animator Anim;
    private Transform player;

    private float smoothSpeed = 20.0f;

        private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {


        Anim = gameObject.GetComponent<Animator>();

        StartCoroutine(initialDelay());

        player = GameObject.Find("Robot (Player)").transform;

        offset = transform.position - player.position;
    }

    void FixedUpdate()
    {

        Vector3 desiredPosition = player.position + offset;


        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);


        transform.position = smoothPosition;


        if (PlayerController.playerDead == 1)
        {
            Anim.SetBool("isRunning", false);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

        }

    }

    IEnumerator initialDelay()
    {

        yield return new WaitForSeconds(PlayerController.initialDelay);
        Anim.SetBool("isRunning", true);
    }
}
