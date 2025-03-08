using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAI : MonoBehaviour
{
    public GameObject Target;
    public float Distance;

    private PlayerMovementTutorial monster;
    private Rigidbody rigidbody;

    private void Awake()
    {
        monster = GetComponent<PlayerMovementTutorial>();
        rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Distance = Vector3.Distance(transform.position, Target.transform.position);

        if(Distance >= 7 && monster.active != true)
        {
            var _targetPosition = Vector3.MoveTowards(transform.position, Target.transform.position, 5 * Time.deltaTime);
            rigidbody.MovePosition(_targetPosition);
        }
    }
}
