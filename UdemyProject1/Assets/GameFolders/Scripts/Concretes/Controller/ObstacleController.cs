using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Pools;
using UnityEngine;

namespace UdemyProject1.Controllers
{
    public class ObstacleController : RedDragonController
    {
        public override void SetEnemyPool()
        {
            ObstaclePool.Instance.Set(this);
        }
    }
}

