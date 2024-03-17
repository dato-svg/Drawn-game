using System;
using System.Collections.Generic;
using UnityEngine;

public class TrapMove : MonoBehaviour
{
    [SerializeField] private List<Transform> points = new List<Transform>();
    [SerializeField] private RectTransform rectTransform;
    [SerializeField] private float speed;

    private int _currentIndex;


    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        rectTransform.Rotate(new Vector3(0,0,1));
        
        rectTransform.position =
            Vector3.MoveTowards(rectTransform.position, points[_currentIndex].position, speed * Time.deltaTime);
        
        if (Vector3.Distance(rectTransform.position,points[_currentIndex].position) < 0.1f)
        {
            _currentIndex++;
            if (_currentIndex >= points.Count)
            {
                _currentIndex = 0;
            }
        }

    }
}
