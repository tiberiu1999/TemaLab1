using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public Animation animations;
    // Start is called before the first frame update
    void Start()
    {
        animations = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        float Dist = Vector3.Distance(Camera.main.transform.position, transform.position);
        if (Dist < 0.2)
            animations.Play("atacare");
        else
            animations.Play("Death");
    }
}
