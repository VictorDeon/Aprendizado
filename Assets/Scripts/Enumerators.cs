using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumerators : MonoBehaviour {

    enum STATE {
        ATK,
        RUN,
        STAY
    }

    void Start() {
        STATE state = STATE.ATK;
        print(state);
        state = STATE.RUN;
        print(state);
        print((int) state);
    }

    void Update() {
        
    }
}
