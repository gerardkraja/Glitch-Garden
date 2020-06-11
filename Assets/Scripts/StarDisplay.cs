using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int starCount = 100;
    Text starText;
    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        starText.text = starCount.ToString();
    }

    public bool HaveEnoughStars(int amount)
    {
        return starCount >= amount;
    }

    public void AddStars(int starAddition)
    {
        starCount += starAddition;
        UpdateDisplay();
    }

    public void SpendStars(int starPayment)
    {
        if (starCount >= starPayment)
        {
            starCount -= starPayment;
            UpdateDisplay();
        }
    }
}
