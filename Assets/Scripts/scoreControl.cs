using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreControl : MonoBehaviour
{
    public Text score;
    public static int scoreNum;
    // Start is called before the first frame update
    private void Awake()
    {
        score = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        score.text = scoreNum.ToString();
    }
}
