using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Unittestai_2
{
    public struct Mokinys
    {
        public List<int> trimestras1;
        public List<int> trimestras2;
        public List<int> trimestras3;

    
        private double PaskaiciuotiVidurki(List<int> pazymaiai)
        {
            int pazymiuSuma = 0;
            double vidurkis = 0;

            foreach (var item in pazymaiai)
            {
                pazymiuSuma += item;
            }
            if(pazymaiai.Count == 0)
            {
                vidurkis = 0;
            }
            else
            {
                vidurkis = pazymiuSuma / pazymaiai.Count;
            }
             

            return vidurkis;
        }
        public double IsvestiPirmoTrimestroVidurki()
        {           
            return PaskaiciuotiVidurki(trimestras1);
        }

        public double IsvestiAntroTrimestroVidurki(List<int> aTrimestras2)
        {
            return PaskaiciuotiVidurki(trimestras2);
        }

        public double IsvestiTrecioTrimestroVidurki(List<int> aTrimestras3)
        {
            return PaskaiciuotiVidurki(trimestras3);
        }

        public double IsvestiMetiniVidurki()
        {
            double metinisVidurkis = (PaskaiciuotiVidurki(trimestras1) + PaskaiciuotiVidurki(trimestras2) + PaskaiciuotiVidurki(trimestras3)) / 3;

            return metinisVidurkis;
        }
    }
}
