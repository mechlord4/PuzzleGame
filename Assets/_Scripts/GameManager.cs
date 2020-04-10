using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Scene current;
    static int hp;
    public Text life;
    public AudioClip right, wrong;
    public AudioSource sound;
    public void Start()
    {
        hp = 2;
    }

    private void Update()
    {
       
       current = SceneManager.GetActiveScene();//get the current scene
        if (hp == 0)
        {
            Death();
        }
        
        life.text = "x" +hp;
    }
    public void toGame()// move to the first game scene
    {
        SceneManager.LoadScene("Q1");
    }
    public void toMenu()
    {
        SceneManager.LoadScene("Title");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Wrong()// what happens if you answer wrong
    {
        hp--;
    }
    public void Death()// load loss scene
    {
        SceneManager.LoadScene("Loss");
        sound.PlayOneShot(wrong);
    }

  public void Advance()// if the questions are answereed correctly move foward 
  {
        sound.PlayOneShot(right);
     if (current.name == "Q1")
     {
         SceneManager.LoadScene("Q2");
     }
     else if (current.name == "Q2")
     {
         SceneManager.LoadScene("Q3");
     }
     else if (current.name == "Q3")
     {
         SceneManager.LoadScene("Q4");
     }
     else if (current.name == "Q4")
     {
         SceneManager.LoadScene("Q5");
     }
     else if (current.name == "Q5")
     {
         SceneManager.LoadScene("Q6");
     }
     else if (current.name == "Q6")
     {
         SceneManager.LoadScene("Q7");
     }
     else if (current.name == "Q7")
     {
         SceneManager.LoadScene("Q8");
     }
     else if (current.name == "Q8")
     {
         SceneManager.LoadScene("Q9");
     }
     else if (current.name == "Q9")
     {
         SceneManager.LoadScene("Q10");
     }
     else if (current.name == "Q10")
     {
         SceneManager.LoadScene("Q11");
     }
     else if (current.name == "Q11")
     {
         SceneManager.LoadScene("Q12");
     }
     else if (current.name == "Q12")
     {
         SceneManager.LoadScene("Q13");
     }
     else if (current.name == "Q13")
     {
         SceneManager.LoadScene("Q14");
     }
     else if (current.name == "Q14")
     {
         SceneManager.LoadScene("Q15");
     }
     else if (current.name == "Q15")
     {
         SceneManager.LoadScene("Win");
     }
    }
}
