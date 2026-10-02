using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class Conjunto {
        private List<Forma> _formas;
        private int _capacidade;

        /// <summary>
        /// Cria um conjunto de formas geométricas com capacidade máxima.
        /// </summary>
        /// <param name="capacidade">Capacidade do conjunto (1 ou mais)</param>
        public Conjunto(int capacidade) {
            _capacidade = 1;
            if (capacidade > 1)
                _capacidade = capacidade;
            _formas = new List<Forma>(_capacidade);
        }

        public int AddForma(Forma nova) {
            if (nova != null && _formas.Count < _capacidade) {
                _formas.Add(nova);
            }
            return _formas.Count;
        }



        public Forma MaiorForma() {
            Forma maior = null;
            if (_formas.Count > 0) {
                maior = _formas.ElementAt(0);
                for (int i = 1; i < _formas.Count; i++) {
                    Forma candidata = _formas.ElementAt(i);
                    if (candidata.TemAreaMaiorQue(maior))
                        maior = candidata;
                }
            }
            return maior;
        }

        public override string ToString() {
            StringBuilder relatorio = new StringBuilder($"Conjunto com {_formas.Count} formas geométricas\n");
            foreach (Forma forma in _formas) {
                relatorio.AppendLine($"{forma}");
            }
            return relatorio.ToString();
        }


    }
}

