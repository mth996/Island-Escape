using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is to delete the game objects in the scene once the players passes them to conserve memory
public class SceneController : MonoBehaviour
{
    private int minimumDistanceDelete = 10;

    private int minimumDistanceDeleteLab = 25;

    private int startDestroy = 0;

    private void Start()
    {
        StartCoroutine(destroyDelay());
    }

    // Update is called once per frame
    void Update()
    {

        if (startDestroy == 1)
        {
            if (this.gameObject.name == "Lab")
            {
                if (transform.position.z < PlayerController.playerPos.z - minimumDistanceDeleteLab)
                {
                    Destroy(gameObject);
                }
            }

            else if (this.gameObject.name.Contains("IslandGround"))
            {
                if (transform.position.z < PlayerController.playerPos.z - minimumDistanceDelete)
                {
                    Destroy(gameObject);
                    GameController.numOfGround -= 1;
                }
            }
        }
    }

    IEnumerator destroyDelay()
    {
        yield return new WaitForSeconds(3);
        startDestroy = 1;
    }
}
