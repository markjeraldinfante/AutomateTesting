using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

    public class HealthUI : MonoBehaviour
    {
        public TextMeshProUGUI livesText;
        public void UpdateLives(float currentLives)
        {
            livesText.text = $"Health: {currentLives}";
        }
        public void GetUpdateLife(float currentHealth)
        {
            Debug.Log($"Health: {currentHealth}");
        }
    }
