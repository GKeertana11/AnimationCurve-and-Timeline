using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public AnimationCurve animationCurve;
    Animation anim;
    float curveTime=3f;
    private float playerSpeed=5f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        //animationCurve.Evaluate(curveTime);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.z += playerSpeed * Time.deltaTime;
        curveTime = 1;
        curveTime = Mathf.PingPong(curveTime,1f);
        currentPosition.y= animationCurve.Evaluate(curveTime);
        Debug.Log(curveTime);
        transform.position = currentPosition;
    }
}
