using UnityEngine;
using Unity.UI;
public class ScoreManager : MonoBehaviour
{
   
    public int score = 0; // score value = 0 at start of game

    public TMPro.TextMeshProUGUI scoreText; // creates a field in the inspector that can have a TMP UGUI element assigned to it

    private void Awake()
    {
        score = 0;
        // sets score value = 0 at start of game
    }
    public void AddPoints() 
    {
       score = score + 10; // sets the score to the current score + 10 
       scoreText.text = score.ToString(); //converts the score to text
      
    }
}


// If you want to add points you can call AddPoints() in another script
// use this  ScoreManager scoreManager; // references the ScoreManager script
// then this  scoreManager.AddPoints(); // accesses ScoreManager script and calls AddPoints method 