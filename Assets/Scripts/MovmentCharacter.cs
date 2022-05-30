using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentCharacter : MonoBehaviour
{
    public Animator Animation;
    public float Speed;

    void Start()
    {
        Animation = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");
        Animation.SetFloat("Vertical", vertical);
        Animation.SetFloat("Horizontal", horizontal);

        transform.Translate(horizontal * Speed, 0, vertical * Speed);
        

    }
}
