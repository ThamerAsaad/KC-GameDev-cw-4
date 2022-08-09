using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int scene = main.scene;
    int score = 0;
    int inc = 1;
    public Text text1;
    public Text inctext;
    public GameObject GIf;
    // Start is called before the first frame update
    void Start()
    {
        GIf.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 100 && score < 119)
        {
            GIf.SetActive(true);
        }
        else if (score >= 120)
        {
            GIf.SetActive(false);
        }
    }  
    public void increase()
    {
        score += inc;
        text1.text = score.ToString();
    }
    public void store()
    {
        if (score >=5 )
        {
            score -= 5;
            inc++;
            text1.text = score.ToString();
            inctext.text = "inc = " + inc;
        }
        else
        {
            print("you don't have enough score");
        }
    }
    public void Reset()
    {
        SceneManager.LoadScene("SampleScene");
    }
}   
