using UnityEngine;

public class Asteroide : MonoBehaviour {

    void Start() {
        
    }

    void Update() {
        // O Vector3 instancia os eixos X, Y e Z

        // Movimentar um gameobject nos seus eixos
        // transform.Translate(new Vector3(0.01f, 0, 0));

        // Rotacionar um gameobject nos seus eixos
        // transform.Rotate(new Vector3(0, 0, -0.5f));

        // Escalonar um gameobject nos seus eixos
        transform.localScale += new Vector3(0.001f, 0.001f, 0);
    }
}
