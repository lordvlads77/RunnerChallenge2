using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //public RandomSpawner randomSpawner;
    [Tooltip("How long to wait before restarting the game")] 
    public float waitTime = 2.0f; 
    private void OnCollisionEnter(Collision collision)
    {
        /*Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 0, Random.Range(-10, 11));
        Instantiate(randomSpawner._Obstacle, randomSpawnPosition, Quaternion.identity);*/
        // First check if we collided with the player 
        if (collision.gameObject.GetComponent<PlayerController>())
        { 
            // Destroy the player 
            Destroy(collision.gameObject);
            // Call the function ResetGame after waitTime 
            // has passed 
            Invoke("ResetGame", waitTime); 
        } 
    } 

    /// <summary> 
    /// Will restart the currently loaded level 
    /// </summary> 
    private void ResetGame() 
    { 
        // Restarts the current level 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    } 
}
