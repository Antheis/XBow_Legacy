﻿using Enemy;
using UnityEngine;

namespace Weapons
{
    public class DamageTrigger : MonoBehaviour
    {
        public float Damage = 10f;

        private void OnTriggerEnter(Collider other)
        {
            var hittable = other.GetComponent<Hittable>();
            Debug.Log("Hit " + other.name + " by " + name);
            if (hittable != null)
                hittable.Hit(Damage, transform.position);
        }
    }
}
