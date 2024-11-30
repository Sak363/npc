using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 5;
    public int levle = 1;
    public float speed = 1.2f;
    void Start()
    {
        health = levle + health;
        print("Жизней" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;


    }
}
