using System;
using UnityEngine;

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

abstract class Animal {
    protected string type = "Carnivoro";
    public static string noise = "RAWWWW...";

    public abstract string Atk(string enemy);

    public virtual string Roar() {
        return noise;
    }

    // Sobrecarga de método
    public string Roar(string noise) {
        return noise;
    }
}

class Feline : Animal {
    public string name;
    private int strength;

    public Feline(string name, string type = null, int strength = 10) {
        this.name = name;
        this.strength = strength;

        if (type != null) {
            base.type = type;
        }
    }

    // Encapsulamento
    public int Strength {
        get {
            return strength;
        }

        set {
            if (value >= 0 && value <= 100) {
                strength = value;
            } else {
                throw new Exception("Valor de força deve ser maior que zero e menor que 100.");
            }
        }
    }

    // Polimorfismo
    public override string Roar() {
        return "Meow!!";
    }

    // Sobrescrita de classe abstrata
    public override string Atk(string enemy) {
        return $"Ataquei com força {strength} no inimigo {enemy}";
    }

    private bool IsCarnivore() {
        if (type == "Carnivoro") {
            return true;
        }
        return false;
    }

    public string Eat() {
        if (IsCarnivore()) {
            return $"Comi carne";
        }

        return $"Comi vegetais";
    }
}