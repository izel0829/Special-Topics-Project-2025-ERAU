using UnityEngine;

public class RobotJoint : MonoBehaviour
{
    public RobotJoint m_child;
    public RobotJoint GetChild()
    {
        return m_child;
    }
    
    public void Rotate(float angle)
    {
        transform.Rotate(Vector3.up, angle);
    }
}
