using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeImage
{
    class SharpnessFilter : MatrixFilters
    {
        public SharpnessFilter()
        {
            kernel = new float[3, 3]
            {
                { 0, -1, 0 },
                { -1, 5, -1 },
                { 0, -1, 0 }
            };
        }
    }

}
