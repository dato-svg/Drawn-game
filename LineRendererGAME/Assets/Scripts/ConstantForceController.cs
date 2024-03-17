
using UnityEngine;

public class ConstantForceController : MonoBehaviour
{
    [SerializeField] private ConstantForce2D _constantForce2D;


    public void ChangeForceX(float speed)
    {
        _constantForce2D.relativeForce = new Vector2(speed,_constantForce2D.relativeForce.y);
    }
    
    public void ChangeForceY(float speed)
    {
        _constantForce2D.relativeForce = new Vector2(_constantForce2D.relativeForce.x,speed);
    }
}
