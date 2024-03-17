using UnityEngine;

public class TrapRotation : MonoBehaviour
{
    [SerializeField] private RectTransform rectTransform;
    [SerializeField] private float speed = 30;
    
    private int rotationDirection = 1; 

    private void Update()
    {
        
        float targetRotation = (rotationDirection == 1) ? 90f : 0f;
        float currentRotation = rectTransform.rotation.eulerAngles.z;

        
        float newRotation = Mathf.MoveTowardsAngle(currentRotation, targetRotation, speed * Time.deltaTime);
        rectTransform.rotation = Quaternion.Euler(0, 0, newRotation);

       
        if (Mathf.Abs(newRotation - targetRotation) < 0.1f)
        {
            rotationDirection *= -1;
        }
    }
}