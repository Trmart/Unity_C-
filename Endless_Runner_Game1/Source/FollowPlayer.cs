//Taylor Martin
//CS-151
//PA 6 Game with Inheritence and Polymorphism 
//5/14/20
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; 
    public Vector3 offset; //vector 3 stores 3 floats 
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; 
    }
}
