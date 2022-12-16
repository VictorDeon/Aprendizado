using System.Collections.Generic;
using UnityEngine;

// Quando você não sabe a quantidade de itens do array
public class Colecoes : MonoBehaviour {

    List<int> list01 = new List<int>();
    List<int> list02 = new List<int>();

    void Start() {
        list01.Add(100);
        list01.Add(200);
        list01.Add(300);
        print(list01[1]);
        list01.Remove(200);
        print(list01[1]);
        print(list01.IndexOf(300));
        for(int i = 0; i < 10; i++) {
            list02.Add(i + 1);
        }
        foreach(int valor in list02) {
            print(valor);
        }
    }

    void Update() {
        
    }
}
