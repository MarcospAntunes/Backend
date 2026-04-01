using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BallBehaviour : MonoBehaviour
{
  public float XRotation = 0;
  public float YRotation = 1;
  public float ZRotation = 0;
  public float degreesPerSecond = 180;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 axis = new Vector3(XRotation, YRotation, ZRotation);
    // transform.Rotate(axis, degreesPerSecond * Time.deltaTime); -> Gira o GameObject em torno de seu centro
      transform.RotateAround(Vector3.zero, axis, degreesPerSecond * Time.deltaTime); // Gira o GameObjetct em torno de um ponto na cena
      Debug.DrawRay(Vector3.zero, axis, Color.yellow, .5f);
    }
}
