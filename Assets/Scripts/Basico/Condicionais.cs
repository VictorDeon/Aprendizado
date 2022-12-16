using UnityEngine;

public class Condicionais : MonoBehaviour {

    int heroCoint = 80;
    int life = 100;
    string msg = "";
    // 1 - Coragem
    // 2 - Meio Termo
    // 3 - Covardia
    int mosterState = 1;

    // Roda antes do primeiro frame disparar
    void Start() {
        if (heroCoint == life) {
            msg = "Posso comprar vida, mas fico zerado!";
        } else if (heroCoint > life) {
            msg = "Posso comprar vida!";
        } else {
            msg = "Não tenho dinheiro suficiente para comprar vida";
        }

        // Operadores Ternários
        msg = (heroCoint >= life) ? "Posso comprar vida!" : "Não tenho dinheiro suficiente para comprar vida!";
        print(msg);

        // Switch Case
        switch(mosterState) {
            case 1:
                print("Vilão atacou!");
                break;
            case 2:
                print("Vilão vai atacar, mas está na defensiva");
                break;
            case 3:
                print("Vilão vai fugir");
                break;
            default:
                print("Vilão não está fazendo nada");
                break;
        }
    }

    // Roda a cada frame disparado
    void Update() {
    }
}