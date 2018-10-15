using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {
    public GameObject jugador;
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(jugador.transform.position.x+8,
            0,jugador.transform.position.z-10);
	}
}