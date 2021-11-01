using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Controllers;
using UnityEngine;

namespace UdemyProject1.Combats
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectilePrefab;
        [SerializeField] Transform projectileTransform;
        [SerializeField] GameObject projectileParent;

        float _currentDelayTime;
        bool _canLaunch = false;

        private void Update()
        {
            _currentDelayTime += Time.deltaTime;

            if (_currentDelayTime > Time.deltaTime)
            {
                _canLaunch = true;
            }
        }

        public void LaunchAction()
        {
            if (_canLaunch)
            {
               ProjectileController newProjectile = Instantiate(projectilePrefab, projectileTransform.position, projectileTransform.transform.rotation);

                newProjectile.transform.parent = projectileParent.transform;
                _canLaunch = false;
            }
        }
    }
}


