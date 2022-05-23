using Scripts.Units;
using UnityEngine;

namespace Scripts.Projectile
{
    public class Projectile : MonoBehaviour
    { 
        
        public Unit Target { get; private set; }
        public Unit Launcher { get; private set; }
        
        public delegate void OnHit(Unit target);

        private OnHit _on_target_hit_event;
        
        private void Update()
        {
            
        }
    }
}