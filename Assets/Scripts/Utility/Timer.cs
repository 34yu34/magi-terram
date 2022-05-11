using UnityEngine;

namespace Scripts.Utility
{
    public class Timer
    {

        private float _time_added;
        private float _end_timestamp;
        
        private Timer(float time_to_wait = 0f)
        {
            _time_added = time_to_wait;
            _end_timestamp = Time.time + time_to_wait;
        }

        public bool IsCompleted()
        {
            return _end_timestamp <= Time.time;
        }

        public void Reset()
        {
            _end_timestamp = Time.time + _time_added;
        }

        public static Timer In(float time)
        {
            return new Timer(time);
        }
    }
}