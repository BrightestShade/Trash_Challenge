using UnityEngine;
using Unity.UI;
public class ScoreManager : MonoBehaviour
{
   
    public int score = 0; // score value = 0 at start of game

    public TMPro.TextMeshProUGUI scoreText;

    private void Awake()
    {
        score = 0;
        // score value = 0 at start of game
    }
    public void AddPoints() 
    {
       score = score + 10; // sets the score to the current score + 10 
       scoreText.text = score.ToString(); //converts the score to text
      
    }
}
