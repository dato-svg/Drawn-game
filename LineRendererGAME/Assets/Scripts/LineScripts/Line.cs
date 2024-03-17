using System;
using System.Collections.Generic;
using UnityEngine;

namespace LineScripts
{
    public class Line : MonoBehaviour
    {
        [SerializeField] private LineRenderer _lineRenderer;
        [SerializeField] private EdgeCollider2D _collider2D;
        
        private List<Vector2> _points = new List<Vector2>();

        private void Start()
        {
            _collider2D.transform.position -= transform.position;
        }


        public void SetPosition(Vector2 pos)
        {
            if (_collider2D != null)
            {
                if (!CanPaint(pos)) { return; }
                _points.Add(pos);
                _lineRenderer.positionCount++;
                _lineRenderer.SetPosition(_lineRenderer.positionCount -1,pos);
                _collider2D.points = _points.ToArray();
            }
           
        }

        private bool CanPaint(Vector2 pos)
        {
            if (_lineRenderer.positionCount == 0) { return true; }

            return Vector2.Distance(_lineRenderer.GetPosition(_lineRenderer.positionCount - 1), pos) >
                   LineManager.SPEED;
        }
    }
}
