using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{

    public Transform heartObj;
    public Transform magnetObj;
    public Transform doublePointsCoinObj;
    public Transform mysteryCardObj;

    private Vector3 nextPowerUpSpawn;
    private int randomPowerUpSpawn;

    // Start is called before the first frame update
    void Start()
    {
        nextPowerUpSpawn.z = Random.Range(50,65);
        StartCoroutine(SpawnPowerUp());
    }

    IEnumerator SpawnPowerUp()
    {
        yield return new WaitForSeconds(5);

        // Randomized spawn index between 0 to 5 where only 1 to 4 will spawn powerups
        randomPowerUpSpawn = Random.Range(0, 6);
    
        nextPowerUpSpawn.x = Random.Range(-3, 3);
        nextPowerUpSpawn.y = Random.Range(1.5f, 2.0f);

        if (randomPowerUpSpawn == 1)
        {
            Instantiate(heartObj, nextPowerUpSpawn, heartObj.rotation);
        }

        else if (randomPowerUpSpawn == 2)
        {
            Instantiate(magnetObj, nextPowerUpSpawn, magnetObj.rotation);
        }

        else if (randomPowerUpSpawn == 3)
        {
            Instantiate(doublePointsCoinObj, nextPowerUpSpawn, doublePointsCoinObj.rotation);
        }

        else if (randomPowerUpSpawn == 4)
        {
            Instantiate(mysteryCardObj, nextPowerUpSpawn, heartObj.rotation);
        }

        nextPowerUpSpawn.z += Random.Range(55, 75);
        StartCoroutine(SpawnPowerUp());
    }

}
