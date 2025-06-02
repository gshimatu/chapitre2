using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre2
{
    public class PresidentEtudiant2 : IEtudiant
    {
        public string nom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string promotion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string faculte { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AfficherInfos()
        {
            throw new NotImplementedException();
        }
        public void PayerFrais(double montant)
        {
            throw new NotImplementedException();
        }
    }
}
