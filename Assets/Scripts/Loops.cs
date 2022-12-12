using UnityEngine;

public class Loops : MonoBehaviour {

    string[] inimigos = { "caveira", "matador", "atirador" };

    void Start() {
        print("Laço FOR");
        for(int i = 0; i <= 10; i++) {
            print(i);
        }

        print("Laço WHILE");
        int j = 0;
        while(j <= 10) {
            print(j);
            j++;
        }

        print("Laço DO WHILE");
        int k = 10;
        do {
            print(k);
            k++;
        } while (k <= 10);

        print("Laço FOREACH");
        foreach(string nome in inimigos) {
            print(nome);
        }

        print("Break e Continue");
        for (int i = 0; i <= 20; i++) {
            // Pula os numeros pares
            if (i % 2 == 0) {
                continue;
            }
            // Para no 9;
            if(i == 11) {
                break;
            }
            print(i);
        }
    }

    void Update() {
        
    }
}
