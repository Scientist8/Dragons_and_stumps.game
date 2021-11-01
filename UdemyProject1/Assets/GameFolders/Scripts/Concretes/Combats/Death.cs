using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Combats
{
    public class Death : MonoBehaviour
    {
        bool _isDead;
        public bool IsDead => _isDead;

        public event System.Action OnDeath;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _isDead = true;
            OnDeath?.Invoke();
            Time.timeScale = 0f;
        }
    }
}

