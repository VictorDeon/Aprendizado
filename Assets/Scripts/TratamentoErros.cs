using System;
using UnityEngine;

public class TratamentoErros : MonoBehaviour {
    void Start() {
        int result = 0;
        try {
            result = Convert.ToInt32("Ola error");
        } catch(Exception error) {
            print("Ocorreu um error interno: " + error.Message);
        } finally {
            print(result);
        }
    }

    void Update() {
        
    }
}
