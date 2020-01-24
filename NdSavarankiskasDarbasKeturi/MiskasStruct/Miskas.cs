using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MiskasStruct
{
    public struct Miskas
    {
        public List<int> medziai;
       
        public void PasodintiMedi()
        {
            int medis = 1;
            medziai.Add(medis);
        }
    }

    
}
