using System;

namespace Mammal {
    // interface -> Define quais opera��es o objeto que herdou ir� implementar, diferente
    // do abstract vc n�o define nada dentro da classe apenas a casca.
    interface AnimalInterface {
        public string Roar();
        public string Roar(string noise);
    }

    // sealed -> Faz com que a classe n�o possa ser herdada.
    // abstract -> Faz com que a classe n�o possa ser instanciada.
    abstract class Animal : AnimalInterface {
        protected string type = "Carnivoro";
        public static string noise = "RAWWWW...";
        
        // Obriga todos que herdar a implementar esse metodo
        public abstract string Atk(string enemy);

        // Suas classes filhas podem sobrescrever o comportamento desse metodo. (Polimorfismo)
        public virtual string Roar() {
            return noise;
        }

        // Sobrecarga de m�todo (Mesmo nome do metodo mas estrutura diferente)
        public string Roar(string noise) {
            return noise;
        }
    }

    class Feline : Animal {
        public string name;
        private int strength;

        // Construtor (Destrutor ~Feline(){...} )
        public Feline(string name, string type = null, int strength = 10) {
            this.name = name;
            this.strength = strength;

            if (type != null) {
                base.type = type;
            }
        }

        // Encapsulamento (GET e SET)
        public int Strength {
            get {
                return strength;
            }

            set {
                if (value >= 0 && value <= 100) {
                    strength = value;
                } else {
                    throw new Exception("Valor de for�a deve ser maior que zero e menor que 100.");
                }
            }
        }

        // Polimorfismo (Sobrescrevendo o comportamento da classe pai)
        public override string Roar() {
            return "Meow!!";
        }

        // Sobrescrita de classe abstrata
        public override string Atk(string enemy) {
            return $"Ataquei com for�a {strength} no inimigo {enemy}";
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
}