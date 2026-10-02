using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class Forma {

        private string _descricao;

        public Forma(string descricao) {
            _descricao = descricao;
        }

        public double Area() {
            return 0;
        }

        public double Perimetro() {
            return 0;
        }

        public bool TemAreaMaiorQue(Forma outra) {
            return this.Area() > outra.Area();
        }

        public override string ToString() {
            return $"{_descricao} com área de {Area():F4}";
        }

    }

}
