using System;
using UnityEngine;

namespace Propriétés
{
    public class Ex2 : MonoBehaviour
    {
        private Calendar _calendar = new Calendar();

        private void Update()
        {
            _calendar.Days++;
            _calendar.Months++;
            Debug.Log(_calendar.Days + " days.");
            Debug.Log(_calendar.Months + " months.");
            Debug.Log(_calendar.Years + " years.");
        }
    }
    
    public class Calendar
    {
        public int Years { get; private set; }
        private int _months;
        public int Months
        {
            get => _months;
            set
            {
                _months = value;
                if (_months > 12)
                {
                    Years++;
                    _months = 1;
                }
            }
        }

        private int _days;
        public int Days
        {
            get => _days;
            set
            {
                _days = value;
                if (_days > 30)
                {
                    Months++;
                    _days = 1;
                }
            }
        }
    }
}