using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Combats;
using UnityEngine;

namespace UdemyProject1.UIs
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;

        private void Awake()
        {
            gameOverPanel = transform.GetChild(1).gameObject;
        }

        private void Start()
        {
            Death death = FindObjectOfType<Death>();
            death.OnDeath += HandleOnDeath;  
        }

        private void HandleOnDeath()
        {
            gameOverPanel.SetActive(true);
        }
    }
}