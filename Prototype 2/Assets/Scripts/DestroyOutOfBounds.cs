using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 30;
    private float lowerBound = -10;
    //public TextMeshProUGUI gameOverText;
    /*public void RestartScene(){
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);
    }*/

    
    //PlayerController player  = thePlayer.GetComponent<PlayerController>();
    void Start()
    {
        //gameOverText.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound){
            Destroy(gameObject); 
        }
        else if (transform.position.z < lowerBound){
            Debug.Log("Game Over!");
            
          //  Debug.Log("Your Score is : " + PlayerController.score);
         //   PlayerController.score = 0;
            
        }
    }
    
}
