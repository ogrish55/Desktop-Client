using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.ProductLineServiceReferencee;
using GUI.ModelLayer;

namespace GUI.Utilities
{
    interface IConvertModel
    {
        Product ConvertFromServiceProduct(ServiceProduct serviceProduct);
        ServiceProduct ConvertToServiceProduct(Product desktopProduct);

    }
}
