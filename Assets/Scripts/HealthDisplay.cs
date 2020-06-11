using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] int playerHealth = 500;
    [SerializeField] int damagePerAttacker = 50;
    Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        healthText.text = "Health: " + playerHealth.ToString();
    }

    public void DealDamage()
    {
        playerHealth -= damagePerAttacker;
        UpdateDisplay();
        if (playerHealth <= 0)
        {
            FindObjectOfType<LevelLoader>().LoadNextScene();
        }
    }
}
