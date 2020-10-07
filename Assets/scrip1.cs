using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    private Animation animation;

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        float Dist = Vector3.Distance(Camera.main.transform.position, transform.position);
        if (Dist < 0.3)
            animation.Play("Death");
        else
            animation.Play("atacare");
    }
}