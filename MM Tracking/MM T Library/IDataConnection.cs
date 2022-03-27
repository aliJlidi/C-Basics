using MM_T_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_T_Library
{
    interface IDataConnection
    {
        // read instrument
        List<instrument> instrument_GetAll();
        // create instrument
        void instrument_Create(instrument ins);
        // edit instrument
        void instrument_Edit(instrument ins);
        // delete instrument 
        void instrument_Delete(instrument ins);
    }
}
