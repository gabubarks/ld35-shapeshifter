﻿using UnityEngine;
using System.Collections;

public class WallMove : MonoBehaviour {
  public float speed;
  public Camera camera;
  public GameObject wallShape;

  void Start() {
    ResetWall();
  }

  void Update () {
    var translation = new Vector3(0.0f, 0.0f, speed) * Time.deltaTime;
    transform.position += translation;

    if (transform.position.z < -10) {
      ResetWall();
    }
    camera.transform.position += translation * 0.1f;
  }

  void ResetWall() {
    wallShape.GetComponent<RandomKeypresses>().Randomize();
    transform.position = new Vector3(transform.position.x, transform.position.y, 28);
    camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, -7.11f);
  }
}
