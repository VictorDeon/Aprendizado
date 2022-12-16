using System;
using UnityEngine;
using Mammal;

public class OrientacaoObjeto : MonoBehaviour {

    Feline gato;
    Feline tigre;

    void Start() {
        print(Feline.noise);

        gato = new Feline(name: "Lila", type: "Herbivoro");
        print(gato.name);
        print(gato.Strength);
        print(gato.Roar());
        print(gato.Atk("Fulano 01"));
        print(gato.Eat());
     
        tigre = new Feline("Diego", strength: 100);
        print(tigre.name);
        print(tigre.Strength);
        try {
            tigre.Strength = 111;
        } catch(Exception error) {
            print(error);
        }
        print(tigre.Strength);
        print(tigre.Roar("GRAWWWW!!!"));
        print(tigre.Atk("Fulano 02"));
        print(tigre.Eat());
    }

    void Update() {
        
    }
}