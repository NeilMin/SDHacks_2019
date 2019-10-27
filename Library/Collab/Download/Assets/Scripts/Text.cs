using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Text : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public static int score;
    
    void Awake(){
        score = 0;
        //text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //text.text = "Score: " + score.ToString();
    }
}
