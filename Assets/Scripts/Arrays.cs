using UnityEngine;

public class Arrays : MonoBehaviour {

    string[] fruits = {"banana", "maça", "uva"};
    int[] numbers = new int[4]{1, 2, 5, 3};
    int[] sequency = new int[10];
    int[,] squareMatriz = new int[2, 2]{{1, 2},{3, 4}};
    int[,] matriz = new int[2, 2];

    void Start() {
        print("ARRAYS UNIDIMENSIONAIS - VETORES");
        print(fruits[1]);
        fruits[1] = "pera";
        print(fruits[1]);

        for(int i = 0; i < 10; i++) {
            sequency[i] = i + 1;
            print($"Item[{i}] = {sequency[i]}");
        }

        foreach (int number in numbers) {
            print(number);
        }

        print("ARRAYS BIDIMENSIONAIS - MATRIZES");
        print(squareMatriz[0, 1]);
        squareMatriz[0, 1] = 12;
        print(squareMatriz[0, 1]);
        // Preenchendo a matriz
        int value = 1;
        for (int line = 0; line <= 1; line++) {
            for(int column = 0; column <= 1; column++) {
                matriz[line, column] = value;
                value++;
            }
        }
        // Mostrando a matriz
        for (int line = 0; line <= 1; line++) {
            for (int column = 0; column <= 1; column++) {
                print($"matriz[{line}, {column}] = {matriz[line, column]}");
            }
        }

    }

    void Update() {
        
    }
}
