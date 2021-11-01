using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Abstracts.Spawners;
using UdemyProject1.Controllers;
using UdemyProject1.Movements;
using UdemyProject1.Pools;
using UnityEngine;

namespace UdemyProject1.Spawners
{
    public class ObstacleSpawner : BaseSpawner
    {
        //[SerializeField] EnemyController[] enemies;

        

        protected override void Spawn()
        {
            RedDragonController poolEnemy = ObstaclePool.Instance.Get();
            poolEnemy.transform.position = this.transform.position;
            poolEnemy.gameObject.SetActive(true);
        }       
    }
}

