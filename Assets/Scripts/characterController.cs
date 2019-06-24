using UnityEngine;

public class characterController : MonoBehaviour
{
    public character _character = new character();
    public static float position = 3f;
    private float _target;


    private void Start()
    {
        _target = position;
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(_target, this.transform.position.y, this.transform.position.z), _character.speed);
        PingPong();
    }

    void PingPong()
    {
        if (transform.position.x == -position)
        {
            _target = position;
        }
        else if (transform.position.x == position)
        {
            _target = -position;
        }
    }

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("cocos"))
        {
            
        }
    }
}